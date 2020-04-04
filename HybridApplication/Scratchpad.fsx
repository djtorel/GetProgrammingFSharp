open System.Collections.Generic

//type OrderItemRequest = { ItemId : int; Count : int }
//type OrderRequest =
//    { OrderId : int
//      CustomerName : string // mandatory
//      Comment : string // optional
//      /// One of (email or telephone), or none
//      EmailUpdates : string
//      TelephoneUpdates : string
//      Items : IEnumerable<OrderItemRequest> } // mandatory

type OrderId = OrderId of int
type ItemId = ItemId of int
type OrderItem = { ItemId : ItemId; Count : int }

type UpdatePreference =
    | EmailUpdates of string
    | TelephoneUpdates of string

type Order =
    { OrderId : OrderId
      CustomerName : string
      ContactPreference : UpdatePreference option
      Comment : string option
      Items : OrderItem list }
