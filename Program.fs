open System

let printGreeting name =
  printfn "Hello %s from F#!" name

module BasicFunctions =
  let sampleFunction1 x = x*x + 3
  let result1 = sampleFunction1 4573
  printfn "The result of squaring the integer 4573 and adding 3 is %d" result1

[<EntryPoint>]
let main argv =
  let result = BasicFunctions.sampleFunction1
  0