type Address =
    { Street: string
      Town: string
      City: string }

type Customer =
    { Forename: string
      Surname: string
      Age: int
      Address: Address
      EmailAddress: string }

let customer =
    { Forename = "Joe"
      Surname = "Bloggs"
      Age = 30
      Address =
          { Street = "The Street"
            Town = "The Town"
            City = "The City" }
      EmailAddress = "joe@bloggs.com" }

let updatedCustomer =
    { customer with
        Age = 31
        EmailAddress = "joe@bloggs.co.uk" }
