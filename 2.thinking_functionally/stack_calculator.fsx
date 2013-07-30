type Stack = StackContents of float list

let push x (StackContents stackContents) =
    StackContents (x :: stackContents)

let pop (StackContents stackContents) =
    match stackContents with 
    | head::tail ->
        let newStack = StackContents tail
        (head, newStack)
    | [] ->
        failwith "Stack Underflow"

let SHOW stack =
    let result, _ = pop stack
    printfn "%f" result
    stack

let binary mathFn stack = 
    let pop1, poppedStack1 = pop stack
    let pop2, poppedStack2 = pop poppedStack1
    push (mathFn pop1 pop2) poppedStack2

let unary mathFn stack =
    let pop, poppedStack = pop stack
    push (mathFn pop) poppedStack

let ADD = binary (+)
let MUL = binary (*)
let SUB = binary (-)
let DIV = binary (/)
let SQR = unary (fun x -> x * x)
let NEG = unary (fun x -> -x)

let ONE = push 1.0
let TWO = push 2.0
let THREE = push 3.0
let FOUR = push 4.0
let EMPTY = StackContents []
let START = EMPTY

let ONE_TWO_ADD = ONE >> TWO >> ADD

START |> ONE_TWO_ADD |> SHOW