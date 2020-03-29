open System.Diagnostics

let sum inputs =
    inputs |> Seq.fold (fun state input -> state + input) 0

[ 1; 2; 3; 4; 5 ] |> sum

let length inputs =
    inputs |> Seq.fold (fun state _ -> state + 1) 0

[ 1; 2; 3 ] |> length

let max inputs =
    (0, inputs)
    ||> Seq.fold (fun acc v ->
            if v > acc then v
            else acc)

[ 1; 4; 8; 12; 8; 3 ] |> max

("foo", 3) ||> printfn "This %s is %d"
