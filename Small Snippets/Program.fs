// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "SumOfSquares:  %i" (SumOfSquares.sumOfSquares 5)
    printfn "SumOfSquares2: %i" (SumOfSquares.sumOfSquares2 5)
    printfn "Press any key to exit..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
