type Animal(noiseMakingStrategy) = 
    member this.MakeNoise = 
        noiseMakingStrategy() |> printfn "Making noise %s"


let dog = Animal ( fun () -> "Woof" )
let cat = Animal ( fun () -> "Meow" )

dog.MakeNoise

cat.MakeNoise