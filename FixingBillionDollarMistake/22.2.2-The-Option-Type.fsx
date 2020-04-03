let aNumber : int = 10
let maybeANumber : int option = Some 10

let calculateAnualPremiumUsd score =
    match score with
    | Some 0 -> 250
    | Some score when score < 0 -> 400
    | Some score when score > 0 -> 150
    | None ->
        printfn "No score supplied! Using temporary premium."
        300

calculateAnualPremiumUsd (Some 250)
calculateAnualPremiumUsd None

type 'a myOption =
    | Some' of 'a
    | None'

let foo bar =
    match bar with
    | Some' b -> printfn "MyOption is %d" b
    | None' -> printfn "MyOption is empty"

foo (Some' 400)