open System.Collections.Generic

let inventory = Dictionary<string, float>()
inventory.Add("Apples", 0.33)
inventory.Add("Oranges", 0.23)
inventory.Add("Bananas", 0.45)
inventory.Remove("Oranges")
let bananas = inventory.["Bananas"]
//let oranges = inventory.["Oranges"]

let inventory' = Dictionary<_,_>()
inventory'.Add("Apples", 0.33)
let inventory'' = Dictionary()
inventory''.Add("Apples", 0.33)
