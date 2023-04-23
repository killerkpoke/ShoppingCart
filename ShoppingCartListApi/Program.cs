using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartListApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });

            //Add DB path
            var dbPath = Path.Join("./shoppingcart.db");
            var conn = new SqliteConnection($"Data Source={dbPath}");
            builder.Services.AddDbContext<ShoppingCartDbContext>(opt => opt.UseSqlite(conn));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");

            app.UseAuthorization();

            /*
             * Get all the shopping cart as list
             */
            app.MapGet("/shoppingcart/list", async (ShoppingCartDbContext db) =>
            await db.shoppingCart.ToListAsync()
            );
            /*
             * Get the pickedup item as a list
             */
            app.MapGet("/shoppingcart/list/pickedup", async (ShoppingCartDbContext db) =>
                await db.shoppingCart.Where(q => q.isPickedUp).ToListAsync()
            );
            /*
             * Get one specific item by ID
             */
            app.MapGet("/shoppingcart/find/{id}", async (int id, ShoppingCartDbContext db) =>
                await db.shoppingCart.FindAsync(id)
                is ShoppingCart shoppingCart ? Results.Ok(shoppingCart) : Results.NotFound()
            );

            /*
            * Update one specific item by ID
            */
            
            app.MapPut("/shoppingcart/update/{id}", async (int id, ShoppingCart shoppingCart, ShoppingCartDbContext db) =>
            {
                var record = await db.shoppingCart.FindAsync(id);
                if (record is null) return Results.NotFound();
                
                record.ItemName = shoppingCart.ItemName;
                record.isPickedUp = shoppingCart.isPickedUp;
                record.Quantity = shoppingCart.Quantity;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });
            /*
             * Create a new cart item
             */
            app.MapPost("/shoppingcart/create", async (ShoppingCart shoppingCart, ShoppingCartDbContext db) =>
            {
                db.shoppingCart.Add(shoppingCart);

                await db.SaveChangesAsync();

                return Results.Created($"/shoppingcart/{shoppingCart.Id}", shoppingCart);
            });
            /*
            * Delete a cart item
            */
            app.MapDelete("/shoppingcart/delete/{id}", async (int id, ShoppingCartDbContext db) =>
            {
                var record = await db.shoppingCart.FindAsync(id);
                if (record is null) return Results.NotFound();

                db.shoppingCart.Remove(record);

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.Run();
        }
    }
}