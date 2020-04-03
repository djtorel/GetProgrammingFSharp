#r "../CSharpProject/bin/Debug/netcoreapp3.1/CSharpProject.dll"

open CSharpProject
open System.Collections.Generic
open System

let tony = Person("Tony", 32)

tony.PrintName()

let longhang =
    [ ("Tony", 32)
      ("Fred", 20)
      ("Samantha", 18)
      ("Brad", 40)
      ("Sophie", 12) ]
    |> List.map (fun p -> Person p)

let shortHand =
    [ ("Tony", 32)
      ("Fred", 20)
      ("Samantha", 18)
      ("Brad", 40)
      ("Sophie", 12) ]
    |> List.map Person

type PersonComparer() =
    interface IComparer<Person> with
        member this.Compare(x, y) =
            if not (x.Name.CompareTo(y.Name) = 0) then x.Name.CompareTo(y.Name)
            else x.Age.CompareTo(y.Age)

let pComparer = PersonComparer() :> IComparer<Person>
pComparer.Compare(Person("Simon", 32), Person("Fred", 12))

let pComparer' =
    { new IComparer<Person> with
        member this.Compare(x, y) =
            if not (x.Name.CompareTo(y.Name) = 0) then x.Name.CompareTo(y.Name)
            else x.Age.CompareTo(y.Age) }

let blank:string = null
let name = "Vera"
let number = Nullable 10
let blankAsOption = blank |> Option.ofObj
let nameAsOption = name |> Option.ofObj
let numberAsOption = number |> Option.ofNullable
let unsafeName = Some "Fred" |> Option.toObj
