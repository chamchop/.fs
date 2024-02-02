open System

let sayHello person = 
    printfn "Hello %s from F#!" person    

let isValid person = 
    String.IsNullOrWhiteSpace person |> not

let isAllowed person =
    person <> "Eve"

[<EntryPoint>]
let main argv = 
    argv 
    |> Array.filter isValid 
    |> Array.filter isAllowed
    |> Array.iter sayHello 
    printfn "Nice to meet you"
    0  

// [<EntryPoint>]
// let main argv = 
//     for person in argv do
//         printfn "Hello %s from F#!" person
//     printfn "Nice to meet you."
//     0

// [<EntryPoint>]
// let main argv = 
//     for i in 0..argv.Length - 1 do
//         let person = argv.[i]
//         printfn "Hello %s from F#!" person
//     printfn "Nice to meet you."
//     0

// [<EntryPoint>]
// let main argv = 
//     let person = 
//         if argv.Length > 0 then
//             argv.[0]
//         else "name"
//     printfn "Hello %s from F#!" person
//     0