// See https://www.nuget.org/packages/FSharp.Data. In [Visual Studio][Package Manger Console]Install-Package FSharp.Data 
#r """..\packages\FSharp.Data.2.3.2\lib\net40\FSharp.Data.dll"""

open FSharp.Data

type MSFTCSV = CsvProvider<"MSFT.csv">


// Parse     :: if data is in a string
// Load      :: if data is in file or web resource
// AsyncLoad :: 

// MSFTCSV

type Stocks = CsvProvider<"MSFT.csv">

//Stocks.

// Download the stock prices
//let msft = Stocks.Load("http://ichart.finance.yahoo.com/table.csv?s=MSFT")
let msft = Stocks.Load("MSFT.CSV")

// Look at the most recent row. Note the 'Date' property
// is of type 'DateTime' and 'Open' has a type 'decimal'
let firstRow = msft.Rows |> Seq.head
let lastDate = firstRow.Date
let lastOpen = firstRow.Open

// Print the prices in the HLOC format
msft.Rows  |> Seq.iter ( fun r -> printfn "%A %A %A %A %A %A %A "  r.Date r.Open r.High r.Low r.Close r.Volume r.``Adj Close``)






// See https://fslab.org/FSharp.Charting/. In [Visual Studio][Package Manger Console]Install-Package FSharp.Charting
#r """..\packages\FSharp.Charting.0.90.14\lib\net40\FSharp.Charting.dll"""

// Load the FSharp.Charting library
#load "../packages/FSharp.Charting.0.90.14/FSharp.Charting.fsx"
open System
open FSharp.Charting

// Visualize the stock prices
let xys = [ for row in msft.Rows -> row.Date, row.Open ]

xys
    |> Chart.FastLine









