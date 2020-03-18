let aString = "Foo"
let someObject = System.Random()

let foo () =
    someObject.Next()

foo()

let foo2() =
    let x = 10
    printfn"%d" (x + 20)
    let x = "test"
    let x = 50.0
    x + 200.0

foo2()