// option types
type StreetAddress = {Line1:string; Line2:string option; Line3:string option }

// Domain type for primitive types
type ZipCode = ZipCode of string
type StateAbbre = StateAbbre of string

// Type Composition
type ZipAndState = {State : StateAbbre; Zip : ZipCode}
type UkAddress = {StreetAddress:StreetAddress; Region: ZipCode}
type UsAddress = {StreetAddress:StreetAddress; Region: ZipAndState}

// Union Types
type Address = 
    | UkAddress 
    | UsAddress

// Creating objects of types
let streetAddr = { Line1 = "5-168"; Line2 = Some("Main Road"); Line3 = None }
let zipCode = ZipCode  "609107"
let stateAbbre = StateAbbre "TN"

let zipAndState = {State = stateAbbre; Zip = zipCode}
let ukAddr : UkAddress = { StreetAddress = streetAddr; Region = zipCode }
let usAddr : UsAddress = { StreetAddress = streetAddr; Region = zipAndState }   


