module arrays

(* Some long comment... *)

let rec sum arr =
    match arr with
    | [||] -> 0
    | xs -> 1 + sum (xs |> Seq.skip 1 |> Array.ofSeq)

let fold arr = Array.fold (fun i _ -> i + 1) 0 arr
let red arr = Array.reduce (fun i _ -> i + 1) arr
let printer name arr = printfn "%s - sum: %i fold: %i red: %i" name (sum arr) (fold arr) (red arr)

// Step is 1
let a = [| 1..5 |]
// Step is 2
let b = [| 1..2..9 |]
// Array comprehention
let c = [| for i in 1..5 -> i |]

printer "a" a
printer "b" b
printer "c" c