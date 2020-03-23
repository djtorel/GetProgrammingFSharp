open System
open System.IO

type Customer =
    { Name: string
      Age: int }

let writeToConsole (text: string) =
    Console.WriteLine(text)

let writeToFile fileName text =
    let pwd = System.IO.Directory.GetCurrentDirectory()
    let path = sprintf "%s/%s" pwd fileName
    File.WriteAllText(path, text)

let printCustomerAge writer customer =
    let messageString name message =
        sprintf "%s is a %s." name message

    let messageName = messageString customer.Name

    if customer.Age < 13 then "child" |> messageName |> writer
    else if customer.Age < 18 then "teen" |> messageName |> writer
    else "adult" |> messageName |> writer

let amy =
    { Name = "Amy"
      Age = 14 }

let printToConsole = printCustomerAge writeToConsole

printToConsole amy

let printToFile = writeToFile "output.txt" |> printCustomerAge
printToFile amy

let test a b = printfn "a: %s, b: %s" a b
let foo = "left" |> test
