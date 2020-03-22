let tupledAdd(a, b) = a + b
let answer = tupledAdd(5,10)

let curriedAdd a b = a + b
let answer' = curriedAdd 5 10

let addFive = curriedAdd 5
let fifteen = addFive 10
