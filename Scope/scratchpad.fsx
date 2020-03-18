open System

//let year = DateTime.Now.Year
//let age = year - 1979
//let estimatedAge = sprintf "You are about %d years old!" age

let estimatedAge =
    let age =
        let year = DateTime.Now.Year
        year - 1979
    sprintf "You are about %d years old!" age

let estimateAges (familyName, year1, year2, year3) =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth

    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3

    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3) / 3
    sprintf "Average age for family %s is %d" familyName averageAge
