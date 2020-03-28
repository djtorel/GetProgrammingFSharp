open System

[ DateTime(2010,5,1)
  DateTime(2010,6,1)
  DateTime(2010,6,12)
  DateTime(2010,7,3) ]
|> List.pairwise
|> List.map(fun (a, b) -> b - a)
|> List.map(fun time -> time.TotalDays)

[ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11 ] |> List.windowed 4
