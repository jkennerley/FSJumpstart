#if INTERACTIVE
#else
module JumpStart
#endif

open System 

//*****************
let x =  42
let hi = "hello"

//*****************
let say me = 
    printfn "%s" me

//*****************
// type inference
let square x = x * x
let sq4 =  square 3
//let sq3p =  square 3.

//*****************
// type inference
let area (l:float) (w:float) = l * w 
//let areaInt (l:float) (w:float) : int = l * w // wont compile 
let areaFloat (l:float) (w:float) : float = l * w //

let area56 =  area 5. 6.
//let sq3p =  square 3.

//*****************
// if then 
let greet name = 
    if String.IsNullOrWhiteSpace(name) then 
        "NONAME"
    else
        name

printfn "%s" (greet "JK" )
printfn "%s" (greet "" )



//*****************
// loop for in do
for x in 1..10 do
  printfn "%i" x

for x in 1..10 do
  printfn "%i" x
  //printfn "%i" x*x // wont cc, need to bracket the (x*x)
  printfn "%i" (x*x) // 
//.....

//*****************
// nest fun, but you cant unit teest then 
for x in 1..10 do
    let sqNested x = x*x
    printfn "%i" (sqNested x) // 
//.....

//*****************
// return 2 things from a fun, tuple and decompose
let RandomPosition () = 
    let random = new System.Random()
    ( random.NextDouble(), random.NextDouble() )
// decompose 2 values from fun return ; tuple no fields names values, so use only for 2/3 values and local usage
let x , y = RandomPosition()
let xyTuple  = RandomPosition()
//.....


//*****************
// Tupling the Arguments
let areaFsWay x y = x + y // No brackets, no comma between the args
let areaTupledArgs ( x, y ) = x+y // brackets and comma between the args
let areaTupledArgs2 ( x, y ) = x,y // returns a tuple, no need to bracket (x,y)
let areaTupledArgs3 ( x, y ) = (x,y) // returns a tuple, no need to bracket (x,y), it is the same thing as x,y
//.....

//*****************
// any external library will appear to have the args tupled together 
open System.IO
// the 
let files = Directory.EnumerateFiles( "c:\jk" , "*.*")
files |> Seq.iter   ( fun x -> printfn "%s" x  )
//.....





//*****************
// partial application, get another function, that takes the remaining parameters
// calling a fun without all the args
let adder x y : int  = x - y
let res1 = adder 1 2 // result is "12"
let res2 = adder 2
let res3 = res2  10
// DONT TUPLE ALL FUNCTIONS, NOT IDIOMATIC F#
//.....



//*****************
// UNIT (), ie and empty tuple
let printer    x = printfn "%s" x // this fun rets unit because printfn rets unit
let notAUnit   () =  printfn "abc" ; ()  // this is a fun, it rets unit(), and deos something 
let funRetsOne () = 1 // this is a fun, it rets int, but takes unit
let notAUnitX   = 1 // this is not fun, it is a let binding 
// EVALUATED ON EACH CALL
let funRetsRandom1 () = 
    let r = System.Random() ; 
    r.NextDouble()
// EVALUATED ONCE, removing the () on the def implies it is a value not a fun
let funRetsRandom2  = 
    let r = System.Random() ; 
    r.NextDouble()

funRetsRandom1()
funRetsRandom2
//.....


//*****************
//let xsTuple = [| 1 , 2  |] // array of tuple
//let xs = [| 1  ;  2  |] // array of int

//.....









