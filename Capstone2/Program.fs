﻿open System
open Capstone2
open Capstone2.Domain
open Capstone2.Operations

[<EntryPoint>]
let main argv =
    let mutable account =
        let customer =
            Console.Write "Please enter your name: "
            let customerName = Console.ReadLine()
            { Name = customerName }

        Console.Write "Enter opening balance: "
        let balance = Console.ReadLine() |> Decimal.Parse
        { AccountId = Guid.NewGuid()
          Customer = customer
          Balance = balance }

    let withDrawWithAudit = withdraw |> auditAs "withdraw" Auditing.console
    let depositWithAudit = deposit |> auditAs "deposit" Auditing.console

    while true do
        let action =
            Console.WriteLine()
            printfn "Current balance is $%M" account.Balance
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            Console.ReadLine()

        if action = "x" then Environment.Exit 0

        let amount =
            Console.Write "Amount: "
            Console.ReadLine() |> Decimal.Parse

        account <-
            if action = "d" then account |> depositWithAudit amount
            elif action = "w" then account |> withDrawWithAudit amount
            else account
    0 // return an integer exit code
