module lists

let rec sum list =
  match list with
  | [] -> 0
  | x :: xs -> 1 + sum xs

let fold list =
  List.fold (fun i _ -> i + 1) 0 list

let red list =
  List.reduce (fun i _ -> i + 1) list

let printer name list =
  printfn "%s - sum: %i fold: %i red: %i" name (sum list) (fold list) (red list)

let a = [1..5]
// Step is 2
let b = [1..2..9]
// list comprehention
let c = [ for i in 1..5 -> i ]

printer "a" a
printer "b" b
printer "c" c
