namespace clases;
public delegate int FuncionEntera(int n);
public delegate bool Predicado(int n);

public static class VectorDeEnterosExtension
{
     public static void Print(this int[] vector, string leyenda) // lo instanciamos a partir de un vector de int : vector.Print("unaLeyendaa")
    {
          Console.WriteLine(leyenda + string.Join(", ", vector));
    }
    public static int[] Seleccionar(this int[] vector, FuncionEntera funcion) // lo instanciamos con un vector, y nos devuelve otro vercor aplicandole la funcion entera
    {
            int[] nuevoVector = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                nuevoVector[i] = funcion(vector[i]);
            }
            return nuevoVector;
    }

    /*
        Aca hay un problema, porque necesito de alguna forma, saber la cantidad de elementos pares o impares
        si uso un array, al hacerlo de la misma longitud, voy a tener posiciones con valor 0

        Deberia recorrerlo primero para saber la cantidad de pares o impares, y en base a eso, hacer un vector de esa cantidad? 
        Porque no encuentro la forma de devolver un vector, sin antes tener que recorrerlo, para evitar los elementos 0
    */ 
    public static int[] Donde (this int[] vector, Predicado predicado)
    {
        int cantElementosCumple =0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (predicado(vector[i])) cantElementosCumple++;
        }

        int [] nuevoVector = new int[cantElementosCumple];

        cantElementosCumple=0;
        for (int i=0; i < vector.Length; i++)
        {
            if (predicado(vector[i])) nuevoVector[cantElementosCumple++] = vector[i];
            
        }
        return nuevoVector;
    }

    
}
