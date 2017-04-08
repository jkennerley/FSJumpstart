module fsharp_sequence_fold_reduce_collect_choose

let xs  =  Seq.init 3 (fun i ->  i * i )

xs

// fold gets passed an accumulator 
let sum1  = Seq.fold ( fun acc x -> acc + x) 0  xs

// reduce takes the first vlaue as an accumulator an initial value for the accumulator
let sum2  = Seq.reduce ( fun acc x -> acc + x) xs

// accumulate strings
let ss  =  Seq.init 3 (fun i ->  i.ToString() )

// 
let ssConcatWitgReduce   = ss |> Seq.reduce ( fun acc x -> acc + x) 
// add comma after accumulator
let ssConcatWithFold   = ss |> Seq.reduce( fun acc x -> acc + "," + x    ) 




