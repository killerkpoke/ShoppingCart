import { Tag } from "./Tag"

interface ShoppingCart {
    Id:number,
    ItemName :string,
    ItemDescription:string, 
    ItemImage:string, 
    Quantity: number,
    isPickedUp:Boolean,
    Price: number, 
    
    Tags: Array<Tag>
}

export {
    ShoppingCart
}


