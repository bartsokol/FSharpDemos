module enums

type CustomerKind =
    | Individual = 1
    | Organization = 2
    | Government = 3

let address cust =
    match cust with
    | CustomerKind.Individual -> "foo.com/private"
    | CustomerKind.Organization -> "foo.com/business"
    | CustomerKind.Government -> "foo.com/nope"
    | _ -> "foo.com/404"

let me = CustomerKind.Individual
let company = CustomerKind.Organization
let they = CustomerKind.Government
let aliens = enum<CustomerKind> 51

printfn "%s" (address me)
printfn "%s" (address company)
printfn "%s" (address they)
printfn "%s" (address aliens)