let max numbers =    
    
    let rec max' x xs =
        match xs with
        | [] -> Some x
        | x' :: xs' -> if x' > x then max' x' xs' else max' x xs'

    match numbers with
    | [] -> None    
    | x :: xs -> max' x xs 

let maxAge = max [25;12;54;41]
