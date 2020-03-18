let sayHello(someValue) =
    let innerFunction(number: int) =
        if number > 10 then "Isaac"
        elif number > 20 then "Fred"
        else "Sara"

    let resultOfInner =
        if someValue < 10.0 then innerFunction(5)
        else innerFunction(15)

    "Hello " + resultOfInner