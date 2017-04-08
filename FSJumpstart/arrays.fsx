namespace FSJumpstart

//***************
open System 

//***************
module fsharp_arrays

//***************
// quick tuple
let t1 = "Smith","John" , DateTime.Now 
let sur, fore, dob = t1

//***************
// create an array of 3 elements
// compound brackets
// semicolons separate elements 
let a1 = [|  1; 2 ; 3 |]

//***************
// create an array of 1 element that is a tuple of 3 values
// compound brackets
// **commas separate elements 
let t1 = "Smith","John" , DateTime.Now , 23
let a2 = [|  1 , "2" ,  3. |]
let a3 = [|  1 , 2 ,  3. |]

//***************
// araay of 99 ints
let ns = [| 1..99 |]
// araay of 10 ints with a step 
let ns1 = [| 1.. 10 .. 99 |]
// random array
let randomFruits count = 
    let r = System.Random()
    let fruits = [| "a" ; "b"  ; "c"  |]
    [|
        for i in 1..count do 
            let index = r.Next(3)
            yield fruits.[index]
    |]
randomFruits(10)

//***************
// array init
let randomFruits2 count = 
    let r = System.Random()
    let fruits = [| "a" ; "b"  ; "c"  |]
    Array.init count (fun i -> 
        let index = r.Next(3)
        fruits.[index]
    )
randomFruits2(10)

//***************
// array access with dot .[i]
let rf = [| "a" ; "b" ; "c" |]

printfn "%s " rf.[0]
printfn "%s " rf.[1]

//***************
// iterate for in do 
let rf = [| "a" ; "b" ; "c" |]
for e in rf do printfn "%s" e

//***************
// iterate for in do 
let rf = [| "a" ; "b" ; "c" |]
rf |> Array.iter (fun e -> printfn "%s" e )

//***************
// iterate for in do 
//let sqs = [|0..10|] |> Array.map (fun x -> x*x )
let sqs = [| for x in 0..20 do yield x*x |]
let isEven x =  x%2 = 0
sqs |> Array.filter isEven 

//***************
// sort
let rf = [| "c" ; "B" ; "a" |]
Array.Sort rf

//***************
// sort
let nms = [| 1 ; 2 ; 3 |]
nms |> Array.sortDescending |> Array.filter isEven

//***************
// easier coding ...
// idiomatic f# ; pipelining

// the long way, with intermediate values
let printLongWords (words: string [] ) = 
    // intermediate result :: inference is top left to botton right
    let longWords : string [] = Array.filter (fun w -> w.Length > 4) words
    let sortedLongWords = Array.sort longWords
    Array.iter (fun w -> printfn "%s" w ) sortedLongWords

let words = [| "xyz"  ; "ABCDEFG" ; "abcde"  ; "ABCDEFG" |]

printLongWords words

//  idiomatc fs code, pipeline
let printLongWords2 (words: string [] ) = 
    words
    |> Array.sort 
    |> Array.filter (fun w -> w.Length > 4) 
    |> Array.iter ( fun w -> printfn " word :: %s"  w )



//***************
// fs map
let sq x = x * x
//...
let sqs = 
    [| 10..20  |]
    |> Array.map (fun x -> x * x )
// nicer
let sqs = 
    [| 10..20  |]
    |> Array.map sq


//***************
// arrays a mutable
let as2 = [|  0 .. 10    |]
as2.[3] <- 9999
as2

 


























