module fsharp_du

type Shape = 
    | Square of float
    | Rectangle of float*float
    | Circle of float


let c = Circle 1.4
let r =  Rectangle ( 2.2 , 1.9 )
let s = Square 1.

let drawingItems = [|  c;r;s |]


let area (s:Shape): float =
    match s with 
    | Square     (x)    -> x * x
    | Rectangle (a,b) -> a*b 
    | Circle (r)    -> System.Math.PI * r *r


let ta =  drawingItems |>Array.sumBy area





