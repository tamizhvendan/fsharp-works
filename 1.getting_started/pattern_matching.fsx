type Shape = 
    | Circle of int
    | Rectangle of int * int
    | Polygon of (int * int) list
    | Point of int * int

let drawShape shape = 
    match shape with 
    | Circle radius -> printfn "Drawing a circle with %d radius" radius
    | Rectangle (height, width) -> printfn "Drawing a rectangle of width %d and height %d" width height
    | _ -> printfn "unable to recognize the shape"

let circle = Circle 10
let rectangle = Rectangle (10, 10)
let polygon = Polygon [(10,10);(1,2)]
let point = Point (2,4)

drawShape polygon