type Result'<'a> =
    | Success' of 'a
    | Failure' of string

type ContactDetails =
    | Address of string
    | Telephone of string
    | Email of string

type CustomerId = CustomerId of string

let insertCustomer contactDetails =
    Success' (CustomerId "Foo")

match insertCustomer (Email "nicki@myemail.com") with
| Success' customerId -> printfn "Saved with %A" customerId
| Failure' error -> printfn "Unable to save: %s" error