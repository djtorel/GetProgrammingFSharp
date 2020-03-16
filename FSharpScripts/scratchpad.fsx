let text = "Hello, World"
text.Length

let greetPerson name age =
    sprintf "Hello, %s. You are %d years old" name age

let greeting = greetPerson "Fred" 25

let countWords (text: string) =
    text.Split(' ').Length

countWords "Hello World Foo"