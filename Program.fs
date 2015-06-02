// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
printfn "Welcome to my Ford Fanatics App for Simple Classes and Enumerators"

type CarType =
    | Tricar = 0
    | FourWheeler = 1
    | Doullies = 2
    | WeirdContraption = 3
    | CrazyMonster = 4


type Truck(year: int, color: string, model: string, wheelcount: int) =
    do 
        if year < 1900 then 
            failwith "We'll assume that no trucks existed prior to 1900"
        if year > 2999 then
            failwith "We'll assume that the Earth will be gone by then due to climate change"


    let CarType =
        match wheelcount with
        | 3 -> CarType.Tricar
        | 4 -> CarType.FourWheeler
        | 6 -> CarType.Doullies 
        | x when x % 2 = 1 -> CarType.WeirdContraption 
        | _ -> CarType.CrazyMonster


    new() = Truck(1995, "Blue", "Ford F-150", 4) // A secondary constructor
    member x.Move() = printfn "The %d %s %s was sold" year color model 
    // The "x" is a self reference available in any class member, like "this" in C# or "self" in Ruby
let truck = Truck()//Instantiation of an instance of the class Car

truck.Move()

let redTruck = Truck(1999, "Red", "Superduty", 4)
redTruck.Move()


[<EntryPoint>]
let main argv = 
    printfn "F not only stands for F#, it stands for FORD!"
    0 // return an integer exit code

