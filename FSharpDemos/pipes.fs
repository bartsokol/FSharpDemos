module pipes

let items = [ 0..99 ]

items
|> List.map (fun i -> String.replicate i "*")
|> printfn "%A"

let matcher =
    function
    | x when x % 15 = 0 -> "foobar"
    | x when x % 5 = 0 -> "bar"
    | x when x % 3 = 0 -> "foo"
    | x -> x.ToString()

let fooBar = Seq.initInfinite (fun i -> i) |> Seq.map matcher

fooBar
|> Seq.skip 100
|> Seq.take 100
|> Seq.iter (fun f -> printfn "%A" f)