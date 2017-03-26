module fsharp_sequences

let pfn (x:int) = printfn "%i" x
let pfns (x:string) = printfn "%s" x



let ais = [| 1..3 |] // array 
let lis = [  1..3 ]  // list

// sequence :: same is IEnumerable
let ss1 = seq { 1..3 }    // seq of int
let ss2 =     { 1..3 }    // seq of int 
let ss3 = Seq.init 5  (fun x -> x*x)  // seq of int 
let ss4 = seq { for x in [0..5] do yield x*x*x  } // seq of int 

ss4

ss3 |> Seq.iter pfn
ss4 |> Seq.iter pfn


open System.IO


let bigFiles = 
    System.IO.Directory.EnumerateFiles "c:\windows"
    |> Seq.map (fun x -> FileInfo  x)
    |> Seq.filter (fun x -> x.Length > 1000000L)
    |> Seq.map (fun x -> x.FullName )
    |> Seq.iter (fun x ->pfns  x )










let files = System.IO.Directory.EnumerateFiles(@"c:\temp")
files |> Seq.iter ( fun x -> printfn "%A" x )

