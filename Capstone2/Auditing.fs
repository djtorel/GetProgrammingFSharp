module Capstone2.Auditing

open Capstone2.Domain

let console account message =
    printfn "Account %O: %s" account.AccountId message
