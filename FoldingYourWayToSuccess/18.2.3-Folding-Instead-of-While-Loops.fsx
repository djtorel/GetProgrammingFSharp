open System.IO

let lines: string seq =
    seq {
        use sr = new StreamReader(File.OpenRead @"book.txt")
        while (not sr.EndOfStream) do
            yield sr.ReadLine()
    }

(0, lines) ||> Seq.fold(fun total line -> total + line.Length)
