let sum inputs =
    let mutable accumulator = 0
    for input in inputs do
        accumulator <- accumulator + input
    accumulator

let length inputs =
    let mutable accumulator = 0
    for _ in inputs do
        accumulator <- accumulator + 1
    accumulator

[ 1; 2; 3 ] |> length

let max inputs =
    let mutable accumulator = 0
    for input in inputs do
        accumulator <-
            if input > accumulator then input
            else accumulator
    accumulator

[ 4; 8; 10; 2; 3 ] |> max
