open System.Collections.Generic
let numbers = List<_>()
numbers.Add(10)
numbers.Add(20)

let otehrNumbers = List()
otehrNumbers.Add(10)
otehrNumbers.Add(20)

let createList(first, second) =
    let output = List()
    output.Add(first)
    output.Add(second)
    output