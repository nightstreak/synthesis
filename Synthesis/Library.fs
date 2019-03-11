module Synthesis

let abelar x =
    x > 12 && x < 3097 && x%12=0
    

let area a b = 
    match a >= 0.0 && b >= 0.0 with
    | false -> failwith "Negative Area"
    |_ -> (a*b)/2.0
        

let zollo num =
    match num < 0 with
    |true -> (*) num -1
    | _ -> num*2

let min woo moo =
    match woo > moo with
    | true -> moo
    |_ -> woo

let max woop mop =
    match woop > mop with
    |true -> woop
    |_ -> mop

let ofTime x y z =
    (x*3600)+(y*60)+z

let toTime seconds =
    match seconds > 0 with
    |true -> let hours = seconds / 3600
             let minutes = (seconds - (hours * 3600))/60
             let seconds = (seconds-(hours *3600)-(minutes *60))
             hours, minutes,seconds
    |_-> 0,0,0        

let digits a =
    let rec count n =
        match n > -10 && n < 10 with
        |true -> 1
        |_->
            match n/10 > 0 with
            |
           
let minmax _ =
    failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"