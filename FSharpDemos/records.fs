module records

type Person = {
    Id : int;
    Name : string;
    Age: int;
    Weight: float
}

type Animal = { Kind: string; IsDomestic: bool }

let bart = { Id = 1; Name = "Bart"; Age = 31; Weight = 75. }
let sokol = { Id = 1; Name = "Bart"; Age = 31; Weight = 75. }
let same = bart = sokol