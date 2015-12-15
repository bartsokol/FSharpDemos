module functions

let multiply x y = x * y
let square x = multiply x x
let negate = multiply -1
let composed = square >> negate
let ``do it all`` x y = y |> multiply x |> composed

let a = multiply 2 3
let b = square a
let c = negate b
let d = ``do it all`` 2 3

printfn "%i -> %i -> %i | %i" a b c d

let rec fib x =
  match x with
  | 0 -> 1
  | 1 -> 1
  | _ -> fib (x-1) + fib (x-2)

let rec fib2 x = function
  | 0 -> 1
  | 1 -> 1
  | _ -> fib (x-1) + fib (x-2)

[0..10] |> Seq.map (fun x -> (x, fib x)) |> Seq.iter (fun (a, b) -> printfn "%i %i" a b)
