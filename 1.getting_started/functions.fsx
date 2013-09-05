let square x = x * x // function definition

let result = square 4 // invoking functions

let square' = square // treating functions as value

let squareOf1to10 = [1..10] |> List.map square' // piping the function

let execFunc func param = func param // Higher order functions

let result2 = execFunc square 4

let rec sum numbers = 
  match numbers with
  | [] -> 0
  | x :: xs -> x + sum xs

printfn "Sum of first 10 numbers is %d" (sum [1..10])