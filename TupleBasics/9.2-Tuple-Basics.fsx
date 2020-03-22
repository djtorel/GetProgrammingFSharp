let parseName(name: string) =
    let parts = name.Split(' ')
    let forename = parts.[0]
    let surname = parts.[1]
    forename, surname

let name = parseName("Isaac Abraham")
let forename, surname = name
let fname, sname = parseName("Isaac Abraham")

let parse (person: string) =
    let parts = person.Split(' ')
    let playerName, game, score = parts.[0], parts.[1], int(parts.[2])
    playerName, game, score

let playerName, game, score = parse("Foo Soccer 2")