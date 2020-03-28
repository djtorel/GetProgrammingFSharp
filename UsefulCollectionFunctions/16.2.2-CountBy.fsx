type person =
    { Name : string
      Town : string }

[ { Name = "Isaac"; Town = "London" }
  { Name = "Sara"; Town = "Birmingham"}
  { Name = "Tim"; Town = "London" }
  { Name = "Michelle"; Town = "Manchester" } ]
|> List.countBy(fun p -> p.Town)
|> List.iter(fun (town, name) -> printfn "%s appeared %d times." town name)
