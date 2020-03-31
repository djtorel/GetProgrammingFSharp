type Customer =
    { Balance: int
      Name: string }

let handleCustomer customers =
    match customers with
    | [] -> failwith "No customers supplied!"
    | [ customer ] -> printfn "Single customer, name is %s" customer.Name
    | [ first; second ] ->
        printfn "Two customers, balance = %d" (first.Balance + second.Balance)
    | customers -> printfn "Customers supplied: %d" customers.Length

handleCustomer
    [ { Balance = 10
        Name = "Joe" } ]

let getStatus customer =
    match customer with
    | { Balance = 0 } -> "Customer has empty balance!"
    | { Name = "Isaac" } -> "This is a great customer!"
    | { Name = name; Balance = 50 } -> sprintf "%s has a large balance!" name
    | { Name = name } -> sprintf "%s is a normal customer" name

{ Balance = 50
  Name = "Joe" }
|> getStatus
