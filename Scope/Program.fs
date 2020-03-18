// Learn more about F# at http://fsharp.org

open System


let doStuffWithTwoNumbers(first, second) =
    let added = first + second
    Console.WriteLine("{0} + {1} = {2}", first, second, added)
    let doubled = added * 2
    doubled

[<EntryPoint>]
let main argv =
    printfn "%i" (doStuffWithTwoNumbers(1, 2))
    0 // return an integer exit code
