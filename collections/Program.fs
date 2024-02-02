open System
open System.IO

let printMeanScore (row : string) =
    let elements = row.Split('\t')
    printfn "%s" row

let summarise filePath =
    let rows = File.ReadAllLines filePath
    let studentCount = (rows |> Array.length) - 1
    printfn "student count %i" studentCount
    rows
    |> Array.skip 1
    |> Array.iter printMeanScore    

[<EntryPoint>]
let main argv = 
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists filePath then        
            printfn "processing %s" filePath
            summarise filePath
            0
        else
            printfn "File not found: %s" filePath
            2
    else
        printfn "Please specify a file"
        1