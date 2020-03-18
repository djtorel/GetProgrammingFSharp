
open System

let explicit: int * int = 10, 5
let implicit = 10, 5

let addNumbers arguments =
    let a, b = arguments
    a + b

let addNumbers' arguments =
    let a, b, c, _ = arguments
    a + b

let result, parsed = Int32.TryParse("3")