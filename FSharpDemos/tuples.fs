module tuples

// You can put values of different types into tuples
let t1 = (1, "a")
// And then unpack them
let (one, a) = t1

// Getting first and second element of tuple is easy
let one' = fst t1
let a' = snd t1

// Pattern matching for tuple
let detuple tuple =
  match tuple with
  | (x, y) -> printfn "%i %s" x y

// You don't have to use parens to define a tuple!
let t2 = 2, "b"

printfn "%i %s" one a
printfn "%i %s" one' a'
detuple t1
detuple t2
