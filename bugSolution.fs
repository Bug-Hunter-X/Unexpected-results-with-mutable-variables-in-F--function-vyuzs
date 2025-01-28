let x = 10
let y = 20

let add x y = 
    let mutable x_local = x
    let mutable y_local = y
    x_local <- x_local + y_local
    y_local <- y_local + x_local
    x_local + y_local

printf "%d %d %d" x y (add x y)