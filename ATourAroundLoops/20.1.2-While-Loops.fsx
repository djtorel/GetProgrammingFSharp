open System.IO

let reader = new StreamReader(File.OpenRead @"File.txt")

while (not reader.EndOfStream) do
    printfn "%s" (reader.ReadLine())
