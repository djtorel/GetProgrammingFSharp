let numbers = [ 1 .. 10 ]
let timesTwo n = n * 2

let outputImperative = ResizeArray()

for number in numbers do
    outputImperative.Add(number |> timesTwo)

let outputFunctional = numbers |> List.map timesTwo

let people =
    [ "Isaac", 30
      "John", 25
      "Sarah", 18
      "Faye", 27 ]

let peopleText = people |> List.map (fun (name, age) -> sprintf "%s is %d years old." name age)

peopleText |> List.iter (fun text -> text |> printfn "%s")
