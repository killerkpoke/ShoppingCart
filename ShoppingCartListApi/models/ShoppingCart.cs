namespace ShoppingCartListApi
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemImage { get; set; }
        public double Quantity{ get; set; }
        public bool isPickedUp { get; set; }
        
        // Foreign key
        public List<Tag> tags { get; set; }
        

    }
}