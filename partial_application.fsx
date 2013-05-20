let genericLogger before after func param = 
    before param
    let result = func param
    after result
    result

let add1 input = input + 1

let add1WithConsoleLogging = genericLogger (fun param -> printfn "Before --> %A" param) (fun result -> printfn "After --> %A" result) add1

add1WithConsoleLogging 5

add1WithConsoleLogging 10
