module fsharp_sequence_collect_choose

// let xs  =  Seq.init 10  (fun i ->  i )
// 
// xs |>  Seq.toArray
// 
// // collect :: applies function to each element and concats the sequence
// 
// let ret1 = xs |> Seq.collect (fun x-> x * x )


type Musician = {name:string ; Instruments: string list}



let band = [    
            {name="A"; Instruments = ["a1" ; "a2"]}
            {name="B"; Instruments = ["b1" ; "b2"]}
            {name="C"; Instruments = ["c1" ; "c2"]}
        ]

// yields seq, and each element is the string list of the instruments
let ret2  = band |> Seq.map (fun p -> p.Instruments)
ret2 // a seq of string-lists

// yields seq, and each element is string :: extract and flatten of sub-list
let ret3  = band |> Seq.map (fun p -> p.Instruments) |> Seq.concat
ret3 |> Seq.toArray


// collect does both the extracton and the flatten
let ret4  = band |> Seq.collect (fun p -> p.Instruments) 
ret4 |> Seq.toArray















// 








