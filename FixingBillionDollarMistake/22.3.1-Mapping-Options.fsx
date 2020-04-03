type Customer =
    { Name : string
      SafetyScore : Option<int> }

let customer =
    { Name = "Bob"
      SafetyScore = Some 501 }

let describe score =
    match score with
    | s when s < 200 -> "Bad"
    | s when s < 500 -> "Medium"
    | s when s > 500 -> "Good"
    | _ -> "Unknown"
let description =
    match customer.SafteyScore with
    | Some score -> Some(describe score)
    | None -> None

let descriptionTwo =
    customer.SafetyScore
    |> Option.map(fun score -> describe score)

let shorthand = customer.SafetyScore |> Option.map describe
let optionalDescribe = Option.map describe