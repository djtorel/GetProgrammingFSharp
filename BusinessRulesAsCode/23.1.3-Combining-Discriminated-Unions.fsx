type CustomerId = CustomerId of string
type ContactDetails =
    | Address of string
    | Telephone of string
    | Email of string

type Customer =
    { CustomerId : CustomerId
      PrimaryContactDetails : ContactDetails
      SecondaryContactDetails : ContactDetails option }

let createCustomer customerId primaryContactDetails secondaryContactDetails =
    { CustomerId = customerId
      PrimaryContactDetails = primaryContactDetails
      SecondaryContactDetails = secondaryContactDetails }

createCustomer (CustomerId "Nicki")  (Email "nicki@myemail.com") (Some (Telephone "123-456-7890"))

type GenuineCustomer = GenuineCustomer of Customer

let validateCustomer customer =
    match customer.PrimaryContactDetails with
    | Email e when e.EndsWith "SuperCorp.com" -> Some(GenuineCustomer customer)
    | Address _ | Telephone _ -> Some(GenuineCustomer customer)
    | Email _ -> None

let sendWelcomEmail (GenuineCustomer customer) =
    printfn "Hello, %A, and welcome to our site!" customer.CustomerId