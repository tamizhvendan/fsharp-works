type 'a Stack =
    | EmptyNode
    | StackNode of 'a * 'a Stack

let head = function
    | StackNode(hd, tl) -> hd
    | EmptyNode -> failwith "Empty Stack"    

let stack = StackNode(10, StackNode(20, EmptyNode))

let headNode = head stack

