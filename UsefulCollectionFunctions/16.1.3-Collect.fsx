type Order =
    { OrderId: int }

type Customer =
    { CustomerId: int
      Orders: Order list
      Town: string }

let customers : Customer list = []

let orders : Order list = customers |> List.collect(fun c -> c.Orders)
