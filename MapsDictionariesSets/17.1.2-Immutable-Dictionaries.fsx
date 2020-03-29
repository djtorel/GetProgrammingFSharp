open System.Collections.Generic

let inventory: IDictionary<string, float> =
    [ "Apples", 0.33
      "Oranges", 0.23
      "Bananas", 0.45 ]
    |> dict

let bananas = inventory.["Bananas"]
inventory.Add("Pineapples", 0.85)
inventory.Remove("Bananas")

let inventory' =
    [ "Apples", 0.33
      "Oranges", 0.23
      "Bananas", 0.45 ]
    |> dict
    |> Dictionary
