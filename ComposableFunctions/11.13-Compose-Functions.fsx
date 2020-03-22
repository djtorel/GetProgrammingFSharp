open System
open System.IO

let checkCreation (dt:DateTime) =
    if dt > DateTime.Now.AddDays(7.0) then "Old"
    else "New"

let checkCurrentDirectoryAge =
    Directory.GetCurrentDirectory
    >> Directory.GetCreationTime
    >> checkCreation

let description = checkCurrentDirectoryAge()
