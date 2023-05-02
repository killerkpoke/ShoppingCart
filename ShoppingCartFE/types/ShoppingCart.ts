import { Tag } from "./Tag"

interface ShoppingCart {
    Id:number,
    ItemName :string,
    ItemDescription:string, 
    ItemImage:string, 
    Quantity: number,
    isPickedUp:Boolean, 
    
    Tags: Array<Tag>
}

export {
    ShoppingCart
}


