using practica5;

internal class Program
{
    private static void Main(string[] args)
    {  
        // Ejercicio 1: 
        /*
        Console.WriteLine("Ejercicio 1: ");
        Cuenta c1 = new Cuenta();
        c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
        Cuenta c2 = new Cuenta();
        c2.Depositar(200).Depositar(800);
        new Cuenta().Depositar(20).Extraer(20);
        c2.Extraer(1000).Extraer(1);
        Console.WriteLine("\nDETALLE");
        Cuenta.ImprimirDetalle();
        */ 

        // Ejercicio 2: 
        /*
        new Cuenta(); 
        new Cuenta();
        List <Cuenta> cuentas = Cuenta.GetCuentas;
        cuentas[0].Depositar(50);
        cuentas.RemoveAt(0);
        Console.WriteLine(cuentas.Count);

        cuentas = Cuenta.GetCuentas;
        Console.WriteLine(cuentas.Count);
        cuentas[0].Extraer(30);
        */ 

        // Ejercicio 4: 
        /*
            4a) La declararcion es correcta. 
            
            4b) Incorrecto. El error que noto aca, es que el constructor estatico sea publico
            No tiene sentido que el constructor estatico sea publico. 
            Los constructores estaticos siempre deberian ser privados.

            4c) Incorrecto. Un constructor estatico no puede recibir parametros.
            los constructores estáticos están diseñados para ejecutar tareas de inicialización 
            que no dependen de ninguna instancia de objeto específica, y por lo tanto no necesitan parámetros.

            4d) Incorrecto. El constructor de instancia A, al no anteponerle el public
            el compilador asume que es privado, lo cual no se podria usar ese constructor.
            Para arreglar esto,tenemos que anteponer la palabra public, para poder hacer uso
            del constructor desde fuera de la clase. 

            4e) Aca hay dos errores: 
            En el constructor estatico, se le quiere asignar un valor a una variable que es de instancia
            es decir, que pertenece a una objeto A en particular. Esto está mal. 
            Tambien esta el caso anterior, donde el constructor de instancia es privado,
            deberia anteponerse la palabra clave public.

            4f)  Correcto. De la unica forma que podriamos instanciar un objeto A
            En este caso, seria a partir del metodo estatico (GetInstancia) que usa el constructor de instancia PRIVADO 
             Entonces solo podemos crear objetos a partir de lGetInstancia. 
             En codigo seria algo asi: A obj1 = A.GetInstancia(); 

            4g) Correcto. Ambas asiganciones son en timpo de compilador

            4h) Incorrecto. 
            La definición de una constante (const) no puede contener una variable. 
            Ni siquiera una variable estática que se asigna en tiempo de compilación. 

            4i) Correcto. Esta es una clase 100% estatica.
            Tiene una lista de int, y en el constructor estatico crea la instancia de la lista.
            Despues a partir del metodo P que recibe un parametro de tipo int, se van agregando los valores
            a la lista. 
            Seria algo como: 
                    A.P(4); 

            4j) Incorrecto. Un dato de tipo readOnly solo puede ser asignado en un constructor.
            En este caso, se le quiere asignar una nueva lista, fuera de un constructor. 

            4k) Correcto. Retorna el valor de un indice del vector.
            (Tener en cuenta que se debe pasar por parametro un indice valido.)

            4l) Incorrecto. Los indizadores solo pueden ser de instancia, no pueden ser estaticos.
        */        

        // Ejercicio 5: 
        /* 
             En el metodo2 se quiere hacer c = 'B' pero es incorrecto, porque c es de instancia. 
             Despues se quiere acceder a la variable st a traves de una instancia de A. Lo cual da error porque
                st es estatica y no pertenece a una clase en particular.
        */ 

        /*
            Ejercicio 8: 
        
        ListaDePersonas lista = new ListaDePersonas();
        lista.Agregar(new Persona("Gianluca",45200602,'M',DateTime.Now));
        lista.Agregar(new Persona("Lautaro",00399499,'M',DateTime.Now));
        Persona p = lista[45200602];
        Console.WriteLine(p.Nombre);

        List<string> listaNombres = lista['D'];
        Console.WriteLine(listaNombres.Count());
        */ 
        
        /* 
            Ejercicio 9: 
            Yo eliminaria la variable de instancia privada. Y usaria la propiedad auto-implementada Marca
            public string Marca{ get; set; }; 
        */ 
        /* Ejercicio 10
private static int a; ==> Variable estatica privada y entera. 
 private static readonly int b;  ==> Variable estatica de solo lectura.
 A() { } ==>> Constructor privado y vacio. 

 public A(int i) : this() { } ==> Constructor publico, que invoca al constructor privado sin oarametros.
 A partir de este constructor,se pueden crear las instancias.
 
 static A() => b = 2;  ==>Constructor estatico, se ejecuta en tiempos de compilacion.

 int c; ==> Variable privada C. 

 public static void A1() => a =  1; ==> Metodo estatico que asigna 1 a una variable estatica. 
 public int A1(int a) => A.a + a; ==> Metodo 
 public static int A2; ==> Variable de instancia publica, a prior
 i sin valor
 static int A3 => 3; ==> Propiedad estatica auto implementada de solo lectura, siempre retorna 3
 La diferencia entre la linea de abajo y la de arriba, es que la de arriba no lleva parametros, 
 por lo tanto es una propiedad.
 private int A4() => 4; ==> Metodo privado que devuelve siempre 4
 public int A5 { get => 5; } ==> Propiedad de instancia, de solo lectura. Retorna 5
 int A6 { set => c = value; }== Propiedad de instancia, de solo escritura. 
 public int A7 { get; set; } ==> Propiedad de instancia, de escritura y lectura
 public int A8 { get; } = 8; ==> Propiedad de instancia, de solo lectura.
 public int this[int i] => i; ==> Indizador, Busca en una estructura un valor indizado que recibe por parametro, y retorna el valor de ese indice,
    */ 
    /* Ejercicio 11: 

     a) public int X = 3; 
     b) public int X => 3;

    a) Es una variable de instancia X con valor 3. 
    b) Es un metodo auto implementado, de solo lectura, siempre retorna 3.

    */ 

    }
}