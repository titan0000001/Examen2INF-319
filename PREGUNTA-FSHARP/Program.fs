// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// UNIV. MACUSAYA AGUILAR YURIKA CI:13846755 LP
let from whom =
    sprintf "from %s" whom
// PREGUNTA 1
//Realice la serie Fibonacci estructurada y recursiva de tres términos hasta n 
//FIBONACCI ITERATIVO
let fiboIterativo n = 
    match n with 
    | 0 -> 0
    | n -> 
        let mutable last = 0
        let mutable next = 1
        for i in 1 .. (n - 1) do
            let temp = last + next
            last <- next
            next <- temp
            printfn "%i" temp
        next
//FIBONACCI RECURSIVO
let rec fib4(n: int):int = 
    match n with
    | 1 | 2 -> n  
    | n -> fib4 (n-1) + fib4 (n - 2)

let function1(n: int) =
  for i in 1 .. n do
    fib4 i |> printfn "%i" |> ignore


 // PREGUNTA 2
 //Resuelva el ejercicio 1 utilizando funciones temporales (lamba) (Haskell, scala, python).
//FUNCIONES LAMBDA USANDO (fun)
let fib =
    (-1, 1) // Initial state
    |> Seq.unfold (fun state ->
        if (snd state > 10) then
            None
        else
            Some(fst state + snd state, (snd state, fst state + snd state)))



// PREGUNTA 3
//Resuelva el ejercicio 1 utilizando funciones de orden superior (Haskell, scala, python).
//FUNCIONES DE ORDEN SUPERIOR
let opcion = fun op arg  -> op arg


[<EntryPoint>]
let main argv =    

    // PREGUNTA 1
    //Realice la serie Fibonacci estructurada y recursiva de tres términos hasta n 
    printf "%s" "FIBONACCI ITERATIVO " 
    //iterativo
    fiboIterativo 7 
    printf "%s " "FIBONACCI RECURSIVO " 
    //recursivo
    function1(7)
    
     // PREGUNTA 2
    //Resuelva el ejercicio 1 utilizando funciones temporales (lamba) (Haskell, scala, python).
    printf "%s" " USANDO LAMBDA USANDO (FUN) " 
    //funciones lambda
    let seq2 =  fib
    for x in seq2 do
        printf "%d " x


    // PREGUNTA 3
    //Resuelva el ejercicio 1 utilizando funciones de orden superior (Haskell, scala, python).
    // como funcion de orden superior    
    printf "%s " "FUNCION DE ORDEN SUPERIOR " 
    opcion fiboIterativo 7
    opcion function1 7    

    

    //let message = from "F#" // Call the function
    //printfn "Hello world %s" message
    0 // return an integer exit code
