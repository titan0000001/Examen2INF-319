object Main extends App{
    //UNIV. MACUSAYA AGUILAR YURIKA
	//PREGUNTA 1
    //FIBONACCI RECURSIVO
    def fiboRecursive(n: Int): Int = {
        if      (n < 2) n
        else    fiboRecursive(n-1) + fiboRecursive(n-2)
    }
    //FIBONACCI ITERATIVO
    def fiboIter(n: Int): Int = {
        var a = -1
        var b = 1
        for (i <- 0 to n){
            var buffer = a
            a = b
            b = buffer + b
            print(b)
        }
            println()
        a
    }

    def main(args:Array[String]):Unit = {
	    //PREGUNTA 1
	    //fIBONACCI RECURSIVO Y ESTRUCTURADO-
	    println(fiboRecursive(7))
	    fiboIter(7)

	    //LISTA DE NUMEROS
	    val num = List(0,1,2,3,4,5,6,7,8,9)

	    //PREGUNTA 2
	    //FUNCIONES DE ORDEN SUPERIOR
	    val result = num.map(y => fiboRecursive(y))
	    println("fibonacci por una Funcion de orden superior : " + result)

	    //PREGUNTA 3
	    //LAMBDA
	    val func = (x:Int) => fiboRecursive(x)
	    println(num.map( func ))
    }
    
}
