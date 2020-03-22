let add x y = x + y
let timesBy x y = x * y

let answer = 10 |> add 5 |> timesBy 2 |> add 20 |> add 7 |> timesBy 3
answer
