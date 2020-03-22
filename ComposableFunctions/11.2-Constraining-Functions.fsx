open System
open System.IO
let buildDt year month day = DateTime(year, month, day)
let buildDtThisYear = buildDt DateTime.UtcNow.Year
let buildDtThisMonth = buildDtThisYear DateTime.UtcNow.Month

let writeToFile (date: DateTime) filename text =
    let path = sprintf "{%s}-{%s}" (date.ToString("yyMMdd")) filename
    File.WriteAllText(path, text)
