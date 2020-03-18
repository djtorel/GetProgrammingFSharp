module Car

open System

let getPetrolUsed destination =
    if destination = "Gas" then 10
    elif destination = "Stadium" then 25
    elif destination = "Office" then 50
    elif destination = "Home" then 25
    else failwith "Unknown destination!"

let calculateRemainingPetrol(currentPetrol, petrolUsed) =
    let remainingPetrol = currentPetrol - petrolUsed
    if remainingPetrol >= 0 then remainingPetrol
    else failwith "Oops! You ran out of petrol!"

let driveTo (petrol, destination) =
    let petrolUsedForDestination = getPetrolUsed destination
    let petrolRemaining = calculateRemainingPetrol(petrol, petrolUsedForDestination)
    if destination = "Gas" then petrolRemaining + 50
    else petrolRemaining