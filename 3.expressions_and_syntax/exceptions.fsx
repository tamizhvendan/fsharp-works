open System

let f throwEx = 
  match throwEx with
  | true -> failwith "Exception !" 
  | false -> "Hello, World!"

printfn "%A" (f false)


exception MyCustomException of string * int
let throwCustomEx throwEx = 
  match throwEx with
  | true -> raise (MyCustomException ("Custome Error!", 10))
  | false -> "Bang!"

try 
  throwCustomEx true
with 
  | MyCustomException (msg, num) -> 
      printfn "MyCustomException %s, %d" msg num
      "Handled Exception!"

let f2 x = 
  try 
    1/x
  with
    | :? DivideByZeroException as ex ->
        printfn "%s" ex.Message
        reraise()

f2 1

let f3 x = 
  try
    if x then "ok" else failwith "fail"
  finally
    printfn "this will always be printed"

f3 true