type person =
    { Name : string
      Town : string }

[ { Name = "Isaac"; Town = "London" }
  { Name = "Sara"; Town = "Birmingham"}
  { Name = "Tim"; Town = "London" }
  { Name = "Michelle"; Town = "Manchester" } ]
|> List.partition(fun p -> p.Town = "London")
