module SumOfSquares

open System

let square x = x * x

let sumOfSquares n =
    [1..n]
    |> List.map square
    |> List.sum

let sumOfSquares2 n =
    List.sumBy square [1..n]