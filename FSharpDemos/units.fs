module units

(* Basic units *)

[<Measure>] type km
[<Measure>] type mile

let kmPerMile = 1.609<km/mile>

let mile2km (x : float<mile>) = x * kmPerMile
let km2mile (x : float<km>) = x / kmPerMile

let dist1 = 25.<km>
let dist2 = 10.<mile>

let dist1mile = km2mile dist1
let dist2km = mile2km dist2

(* Generic units *)

[<Measure>] type hour

let speed (x : float<_>) = x / 1.<hour>

let limitEu = speed 90.<km>
let limitUsa = speed 70.<mile>

(* Combined units *)

[<Measure>] type m
[<Measure>] type sqm = m^2
[<Measure>] type N
[<Measure>] type Pa = N / sqm

let rectArea (w : float<m>) (h : float<m>) = w * h

let h = 3.<m>
let w = 4.<m>
let area = rectArea w h
let areEqual = (12.<m m> = area)

let force = 48.<N>
let presure = force/area
let areEqualToo = 4.<Pa> = presure