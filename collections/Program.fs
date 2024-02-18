open System
open System.IO
open StudentScores

[<EntryPoint>]
let main argv = 
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists filePath then        
            printfn "processing %s" filePath
            try            
                Summary.summarise filePath
                0
            with
            | :? FormatException as e ->
                printfn "error: %s" e.Message
                printfn "incorrect format"
                1
            | :? IOException as e ->
                printfn "error: %s" e.Message
                printfn "file open in other program"
                2
            | _ as e ->
                printfn "unexpected error: %s" e.Message
                3
        else
            printfn "File not found: %s" filePath
            4
    else
        printfn "Please specify a file"
        5