[<Measure>] type gb
type Disk<[<Measure>] 'u> = { Size : int<'u> }

type Computer =
    { Manufacturer : string
      Disks: Disk<gb> list }

let myPC =
    { Manufacturer = "Computes Inc."
      Disks =
          [ { Size = 100<gb> }
            { Size = 250<gb> }
            { Size = 500<gb> } ]}