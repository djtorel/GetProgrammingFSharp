open System

type Rule = string -> (bool * string)

let (isThreeWords: Rule) =
    fun text ->
        printfn "isThreeWords %s" text
        (text.Split ' ').Length = 3, "Must be three words"

let (isLessThan30Chars: Rule) =
    fun text ->
        printfn "isLessThan30Chars %s" text
        text.Length <= 30, "Max length is 30 characters"

let (isAllCaps: Rule) =
    fun text ->
        printfn "isAllCaps %s" text
        text
        |> Seq.filter Char.IsLetter
        |> Seq.forall Char.IsUpper, "All letters must be caps"

let isNotNumber = not << Char.IsNumber

let (isNoNumbers: Rule) =
    fun text ->
        printfn "isNoNumbers %s" text
        text |> Seq.forall isNotNumber, "Cannot contain a number"

let rules: Rule list =
    [ isThreeWords; isLessThan30Chars; isAllCaps; isNoNumbers ]

let buildValidator (rules: Rule list) =
    rules
    |> List.reduce (fun firstRule secondRule word ->
        let passed, error = firstRule word
        if passed then
            let passed, error = secondRule word
            if passed then true, ""
            else false, error
        else
            false, error)

let validate = buildValidator rules
let word = "HELLO FR0M F#"

validate word
