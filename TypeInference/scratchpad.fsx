let add a b =
    let answer = a + b
    answer

add 1 5

//let getLength name = sprintf "Name is %d letters." name.Length 
let getLength (name:string) = sprintf "Name is %d letters." name.Length
let foo(name) = "Hello! " + getLength(name)