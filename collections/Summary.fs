namespace StudentScores

module Summary = 

    open System.IO

    let summarise filePath =
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "student count %i" studentCount
        rows
        |> Array.skip 1
        |> Array.map Student.fromString
        |> Array.sortBy (fun student -> student.GivenName)
        |> Array.iter Student.printSummary