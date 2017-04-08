module sequence_choose

open System
//open FSharp.Data.Sql
open FSharp.Data

// choose elements which are not None

// example 1
let xs  = [  Some 0  ; None ; Some 2  ; None  ; Some 4  ]

//
let ret1 = xs |> Seq.choose id
ret1 |> Seq.toArray

// example 2
let ys ={ 1..20 }
ys

// get list of int options
let xsEvenOptions =  ys |> Seq.map ( fun x -> match x with | x when x%2 = 0  -> Some (x) | _ -> None )

//  pick of the list those elements which are not None
let evens1 = xsEvenOptions |> Seq.choose id
evens1

//  pick of the list those elements which are not None
let evens2 = ys |> Seq.choose ( fun x -> match x with | x when x%2 = 0  -> Some (x) | _ -> None )
evens2
