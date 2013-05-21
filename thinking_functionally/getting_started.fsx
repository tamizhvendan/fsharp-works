// Functions as output

let adderGenerator number = (+) number

let add1 = adderGenerator 1

let add5 = adderGenerator 5

printfn "add1 5 -> %d" (add1 5)

printfn "add5 1 -> %d" (add5 1)

// type constraints on Functions

let evalWith5AndAdd2 ( fn : int->int ) = fn 5 + 2

let square n = n * n

printfn "evalWith5AndAdd2 square --> %i" (evalWith5AndAdd2 square)

// unit type

let unitValue = 1 |> ignore

printfn "%A" unitValue
