module fsharp_lists

open System

//*********
let square x = x * x

//*********
// recap of arrays
// array :: array clamps & semi colons ; mutable elements
let is2 = [|0;10|]  |> Array.map (fun x -> x*x) // 2 elments
let is3 = [|0..10|] |> Array.map (fun x -> x*x) // 10 elements of squares
let is1 = [|2,3|]   |> Array.map (fun (x,y) -> (y,x),x*y) // tuple swap with a result of the multi

let is = [| 1; 2 ; 3 |] 

// list :: square brackets ; immutable
let ls1 = [  1; 2 ; 3  ]
let ls2 = 
    [1;2;3] 
    |> List.map square

// ls2.[1] <- 4 // nofsc








