// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let tony = CSharpProject.Person("Tony", 32)
    tony.PrintName()
    tony.PrintAge()
    0 // return an integer exit code
