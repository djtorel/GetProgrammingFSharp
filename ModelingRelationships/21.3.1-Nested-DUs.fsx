type MMCDisk =
    | RsMmc
    | MmcPlus
    | SecureMMC

type Disk =
    | MMC of MMCDisk * NumberOfPins:int

let foo disk =
    match disk with
    | MMC(MmcPlus, 3) -> "Seeking quietly but slowly"
    | MMC(SecureMMC, 6) -> "Seeking quietly with 6 pins."
    | MMC(_,_) -> "Generic MMC"