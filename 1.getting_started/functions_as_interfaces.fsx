let incrementByOne number = number + 1

let subtractByTwo number = number - 2


let loggableFunction func param =
    printfn "function invoked with param %A" param
    let result = func param
    printfn "%A" (func.GetType())
    printfn "function returns the output %A" result
    result


loggableFunction incrementByOne 5

loggableFunction subtractByTwo 3
    


