module fsharp_options

// See https://fsharpforfunandprofit.com/posts/the-option-type/

(*
dealing with NOTHING, NOWT

Most common exception in c#/vb is null reference

F# option is the fsharp way of delaing with NOWT. 

c# has **2** ways of getting NOWT, i.e. 2 different ways of dealing with NOWT
 - assigning null to reference type
 - Nullable<T> e.g. Nullable<int> .  This onluy worrkd with vlaue types, no nesting, 

Note : 
1. use pattern matching 
2. using "if vOption.IsSome" is anti pattern
3. accessing v.Value when no value will cause exception


Option Types are used extensively in pattern mac

*)

// the binding is to the value 42
let i  =      42

// the binding os to an option, it could be a number or it might not be, 
let io1 = Some 42


// io2 is a let binding to a value, 
// that value could either {None, a_Number }
// this is an int option or Option<int>, and it has the value None in it rather than a number
let io2 = Option<int>.None
io2.IsSome //  IsSome is false because it does not have number
io2.IsNone //  IsNone is true because it does not have number
io2.Value  // try to access the number value. Since the vlaue is Nomne, theere is no 'value', therefore it excepts


let getItDontDoThis(x:int option) = 
    // DONT DO THIS, use the macth statement instead
    if (x.IsSome) then 
        x.Value
    else
        -101

let getItLong (x:int option) = 
    match x with 
        | Some(i) -> i
        | None    -> -102

let getIt = function
        | Some(i) -> i
        | None    -> -103


getIt (Some 42)

getIt (option<int>.None)











