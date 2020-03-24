open System

type Customer =
    { Name : string }

type Account =
    { AccountId : System.Guid
      Customer : Customer
      Balance : decimal }

// Deposit an amount into an account
let deposit amount account =
    { account with Balance = account.Balance + amount }

let withdraw amount account =
    if amount > account.Balance then account
    else { account with Balance = account.Balance - amount }

let console account message =
    printfn "Account %O: %s" account.AccountId message

let auditAs operationType audit operation amount account =
    audit account (sprintf "%O: Performing a %s operation for $%M..." DateTime.UtcNow operationType amount)

    let updatedAccount = operation amount account

    let accountIsUnchanged = (updatedAccount = account)

    if accountIsUnchanged then audit account (sprintf "%O: Transaction rejected!" DateTime.UtcNow)
    else audit account (sprintf "%O: Transaction Accepted! Balance is now $%M." DateTime.UtcNow updatedAccount.Balance)

    updatedAccount

let bob =
    { Name = "Bob" }

let bobsAccount =
    { AccountId = System.Guid.NewGuid()
      Customer = bob
      Balance = 0M }

let depositWithAudit = deposit |> auditAs "deposit" console
let withdrawWithAudit =  withdraw |> auditAs "withdraw" console

bobsAccount |> depositWithAudit 10m |> withdrawWithAudit 5m |> withdrawWithAudit 10m
