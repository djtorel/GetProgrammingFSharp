module OrganizingCodeWithoutClasses.BusinessLogic.DataAccess

type private DbError =
    { Message: string }

let saveCustomer =
        { Name = "Foo"
          Age = 38 }
