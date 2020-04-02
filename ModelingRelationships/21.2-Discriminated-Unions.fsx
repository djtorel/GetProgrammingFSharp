type Disk =
    | HardDisk of RPM:int * Platters:int
    | SolidState
    | MMC of NumberOfPins:int

let myHardDisk = HardDisk(RPM = 250, Platters = 7)
let myHardDiskShort = HardDisk(250, 7)
let args = 250, 7
let myHardDiskTupled = HardDisk args
let myMMC = MMC 5
let mySsd = SolidState

let seek disk =
    match disk with
    | HardDisk( 5400, 5) -> "Seeking very slowly"
    | HardDisk(rpm, 7) -> sprintf "I have 7 spindles and RPM %d" rpm
    | HardDisk _ -> "Seeking loudly at a reasonable speed!"
    | MMC _ -> "Seeking quietly but slowly"
    | SolidState -> "Already found it!"
