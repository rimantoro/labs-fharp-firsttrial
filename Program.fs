open System

let printGreeting name =
  printfn "Hello %s from F#!" name

[<EntryPoint>]
let main argv =
  // Call your new fuhction
  printGreeting "Iman"
  0
