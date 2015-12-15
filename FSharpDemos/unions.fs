module unions

(* Unions *)

type GroupMember = Member of string * int | NotAMember

let bart = Member ("Poznańska Grupa .NET", 3)
let sadman = NotAMember

let display = function
    | Member (group, age) ->  printfn "Lucky member of %s for %i years" group age
    | NotAMember -> printfn "You should join some group!"

display bart
display sadman

(* Plain unions, combined *)

type Animal = Rabbit | Cow | Dog | Cat
type Color = White | Brown | Black
type FarmAnimal = Farm of Color * Animal | Other of Animal

let whiteRabbit = Farm (White, Rabbit)
let blackCow = Farm (Black, Cow)
let cat = Other Cat

let show = function
    | Farm (White, Rabbit) -> printfn "Follow me!"
    | Farm (Black, Cat) -> printfn "Watch out!"
    | Farm (_, _) -> printfn "Hmm..."
    | Other animal -> printfn "I don't know you, %A..." animal

show whiteRabbit
show blackCow
show cat

(* Option *)

open System.IO

let fileLength name =
    match File.Exists(name) with
    | true -> Some (new FileInfo(name)).Length
    | _ -> None

let howBig = function
    | Some len -> printfn "File have size of %A bytes" len
    | None -> printfn "File does not exist!"

let swap = fileLength @"c:\swapfile.sys"
let missing = fileLength @"c:\existing.not"

howBig swap
howBig missing
