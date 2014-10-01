module CreditCardNumberValidationTests

open CreditCardNumberValidation
open FsUnit
open NUnit.Framework

[<Test>]
let ``toDigits Convert positive integers to a list of digits``() =
    toDigits 1234L |> should equal [1;2;3;4]

[<Test>]
let ``toDigits return empty array for 0``() =
    toDigits 0L |> should equal []
    
[<Test>]
let ``toDigits return empty array for negative numbers``() =
    toDigits -1L |> should equal []
    toDigits -100L |> should equal []
    toDigits -23L |> should equal []

[<Test>]
let ``doubleEveryOther should double every other number``()=
    doubleEveryOther [8;7;6;5] |> should equal [16;7;12;5]
    doubleEveryOther [1;3;8;6] |> should equal [2;3;16;6]
    doubleEveryOther [1;2;3] |> should equal [1;4;3]

[<Test>]
let ``sumDigits calculate sum of all the digits``()=
    sumDigits [16L;7L;12L;5L] |> should equal 22

[<Test>]
let ``validate credit card``()=
    validate 4012888888881881L |> should equal true
    validate 4012888888881882L |> should equal false
