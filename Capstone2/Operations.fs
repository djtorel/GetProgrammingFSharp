module Capstone2.Operations

open System
open Capstone2.Domain

// Deposit an amount into an account
let deposit amount account =
    { account with Balance = account.Balance + amount }

// Withdraw an amount from an account
let withdraw amount account =
    if amount > account.Balance then account
    else { account with Balance = account.Balance - amount }

// Perform an action and audit
let auditAs operationType audit operation amount account =
    audit account (sprintf "%O: Performing a %s operation for $%M..." DateTime.UtcNow operationType amount)

    let updatedAccount = operation amount account

    let accountIsUnchanged = (updatedAccount = account)

    if accountIsUnchanged then audit account (sprintf "%O: Transaction rejected!" DateTime.UtcNow)
    else audit account (sprintf "%O: Transaction Accepted! Balance is now $%M." DateTime.UtcNow updatedAccount.Balance)

    updatedAccount
