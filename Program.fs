// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
printfn "Welcome to my Ford Fanatics App for Simple Classes and Enumerators"
printfn "==================================================================="
type CarType =
    | Tricar = 0
    | FourWheeler = 1
    | Doullies = 2
    | WeirdContraption = 3
    | CrazyMonster = 4


type Truck(year: int, color: string, model: string, wheelcount: int) =
    do 
        if year < 1900 then 
            failwith "We assume no cars/trucks existed prior to 1900"
        if year > 2999 then
            failwith "We assume that Earth is gone by 2999 due to climate change"
        if wheelcount < 3 then
            failwith "No car/truck has less than 3 wheels"
        if wheelcount > 10 then
            failwith "Consult Caterpillar for haulers and Mack for semi's"

 // Using pattern-matching on an Enum to deconstruct and also to analyze data     
    let CarType =
        match wheelcount with
        | 3 -> CarType.Tricar
        | 4 -> CarType.FourWheeler
        | 6 -> CarType.Doullies 
        | x when x % 2 = 1 -> CarType.WeirdContraption 
        | _ -> CarType.CrazyMonster // Ford F-650, Cat hauler, Mack semi


    new() = Truck(1995, "Blue", "Ford F-150", 4) // A secondary constructor
    member x.Move() = printfn "The %d %s %s was sold" year color model 
    // The "x" is a self reference available in any class member, like "this" in C# or "self" in Ruby
let truck = Truck()//Instantiation of an instance of the class Car

truck.Move()

let redTruck = Truck(1999, "Red", "Ford F-650 Superduty", 6)
redTruck.Move()

// Using pattern-mmatching with guard conditions tested if the
// pattern itself succeeds.
//Example: computing the sign of a number:
let sign x =
    match x with
    | _ when x < 0 -> -1
    | _ when x > 0 -> 1
    |_ -> 0
  
//You can also combine 2 patterns to 
//represent 2 possible paths for matching:
let getValue a =
    match a with
    | (("lo" | "low"), v) -> v
    | ("hi", v) | ("high", v) -> v
    | _ -> failwith "Expected both a high and low value"
    

[<EntryPoint>]
let main argv =
    printfn "****************************" 
    printfn "F is for F# and Ford!"
    0 // return an integer exit code

