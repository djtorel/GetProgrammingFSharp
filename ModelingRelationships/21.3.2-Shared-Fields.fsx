type Disk =
    | HardDisk of RPM:int * Platters:int
    | SolidState
    | MMC of NumberOfPins:int

type DiskInfo =
    { Manufacturer : string
      SizeGB : int
      DiskData : Disk }

type Computer = { Manufacturer : string; Disks : DiskInfo list }

let myPc =
    { Manufacturer = "Computers Inc."
      Disks =
          [ { Manufacturer = "HardDisks Inc."
              SizeGB = 100
              DiskData = HardDisk(5400, 7) }
            { Manufacturer = "SuperDisks Corp."
              SizeGB = 250
              DiskData = SolidState } ]}

let (|MultOf3|_|) i = if i % 3 = 0 then Some MultOf3 else None
let (|MultOf5|_|) i = if i % 5 = 0 then Some MultOf5 else None

let fizzBuzz i =
    match i with
    | MultOf3 & MultOf5 -> printf "FizzBuzz, "
    | MultOf3 -> printf "Fizz, "
    | MultOf5 -> printf "Buzz, "
    | _ -> printf "%i, " i

[1..20] |> List.iter fizzBuzz