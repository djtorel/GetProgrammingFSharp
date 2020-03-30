for number in 1 .. 10 do
    printfn "%d Hello!" number

for number in 10 .. -1 .. 1 do
    printfn "%d Hello!" number

let customerIds = [ 45 .. 99 ]
for customerId in customerIds do
    printfn "%d bought something!" customerId

for even in 2 .. 2 .. 10 do
    printfn "%d is an even number!" even
