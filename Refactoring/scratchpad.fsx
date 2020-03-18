//let r = System.Random()
//let nextValue = r.Next(1, 6)
//let answer = nextValue + 10

let generateRandomNumber max =
    let r = System.Random()
    let nextValue = r.Next(1, max)
    nextValue + 10

generateRandomNumber 10