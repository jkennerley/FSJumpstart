module fsharp_pattern_matching

// a descriminated union :: 
// shape is a du :: the shape can be Square | Rectangle | Circle
type Shape = 
    | Square of float
    | Rectangle of float*float
    | Circle of float
    //| Ellipse of float
    
// declare an array of shapes, the array contains 3 types ...
let c = Circle 1.4
let r =  Rectangle ( 2.2 , 1.9 )
let s = Square 1.
let drawingItems = [|  c;r;s |]

// pattern matching :: a Shape is passed, the shape is pattern matched with Cicle|Rectangle|Circle
let area (s:Shape): float =
    match s with                                // cf f# compiler and incomplete pattern matching
    | Square    (x)   -> x * x                  // the pattern match extracts relevant values ...
    | Rectangle (a,b) -> a*b                    // the pattern match extracts relevant values ...
    | Circle    (r)   -> System.Math.PI * r *r  // the pattern match extracts relevant values ...
    //| _ -> 0.                                 // cf f# compiler and incomplete pattern matching 

// Note :: adding another type will cause the f# compiuler to issue a warning ...
// let totalArea = drawingItems |> Array.sumBy ( fun s -> area s )
let totalArea = drawingItems |> Array.sumBy area


