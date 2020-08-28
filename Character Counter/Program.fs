// Learn more about F# at http://fsharp.org

open System

let countLength string = String.length string

[<EntryPoint>]
let main argv =
    printfn "Enter a string to have the length calculated!"
    let i = Console.ReadLine()
    printfn "Length: %i" (countLength i)
    0 // return an integer exit code
