module Repro
open Test

[<EntryPoint>]
let main argv =
    printfn "%d" <| fn 5
    0 // return an integer exit code
