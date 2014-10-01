module CreditCardNumberValidation

open System

let toDigits number = 
    let convertCharToNumericalValue c = Char.GetNumericValue c |> int
    match number with
    | x when x <= 0L -> List.empty
    | x -> string x |> Seq.map convertCharToNumericalValue |> Seq.toList 

        
let doubleEveryOther numbers =

    let rec doubleEveryOther' canDoubleHead numbers = 
        match numbers with
        | [] -> []
        | [x] -> if canDoubleHead then [x*2] else [x]
        | [x;y] -> if canDoubleHead then [x*2;y] else [x;y*2]
        | x::y::xs  -> x::(y * 2)::doubleEveryOther' false xs
 
    numbers |> List.rev |> doubleEveryOther' false |> List.rev

let sumDigits numbers =
    numbers |> List.map (fun x -> (toDigits x |> List.sum)) |> List.sum 

let validate creditCardNumber =
    let sum = toDigits >> doubleEveryOther >> List.map int64 >> sumDigits
    (sum creditCardNumber % 10) = 0
    

