namespace Capstone2.Domain

type Customer =
    { Name : string }

type Account =
    { AccountId : System.Guid
      Customer : Customer
      Balance : decimal }
