// Learn more about F# at http://fsharp.org

open System

let Fib number =
    let lookup = Array.create (number + 1) 0
    let rec fib_internal = fun current_number ->
        match current_number with
        | 1 | 2 -> 1
        | current_number ->
            match lookup.[current_number] with
            | 0 ->
                lookup.[current_number] <- fib_internal(current_number-1) + fib_internal(current_number-2)
                lookup.[current_number]
            | x -> x
    fib_internal(number)



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#! %d" (Fib 18)
    0 // return an integer exit code
