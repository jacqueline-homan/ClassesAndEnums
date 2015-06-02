// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
printfn "Welcome to my Ford Fanatics App for Simple Classes and Enumerators"

type Truck(year: int, color: string, model: string) =
    do if year < 1900 then failwith "We'll assume that no trucks existed prior to 1900"
    new() = Truck(1995, "Blue", "Ford F-150") // A secondary constructor
    member x.Move() = printfn "The %d %s %s is moving" year color model 
    // The "x" is a self reference available in any class member, like "this" in C# or "self" in Ruby
let truck = Truck()//Instantiation of an instance of the class Car

truck.Move()

let redTruck = Truck(1999, "Red", "Superduty")
redTruck.Move()


[<EntryPoint>]
let main argv = 
    printfn "F not only stands for F#, it stands for FORD!"
    0 // return an integer exit code

