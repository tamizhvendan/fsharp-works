let number = 4
let isEven n = 
    n % 2 = 0 // No return statement; Last line treated as expression

// In F# 'if' is an expression
let result = if isEven number then "Even" else "Odd" 