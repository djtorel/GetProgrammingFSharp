type CustomerId = CustomerId of string
type Email = Email of string
type Telephone = Telephone of string
type Address = Address of string
type Customer =
    { CustomerId : CustomerId
      Email : Email
      Telephone : Telephone
      Address : Address }

let createCustomer customerId email telephone address =
    { CustomerId = customerId
      Email = email
      Telephone = telephone
      Address = address }

createCustomer
    (CustomerId "C-123")
    (Email "foo@bar.com")
    (Telephone "123-456-7890")
    (Address "123 Fake Street")