using System.Dynamic;

namespace practica5;

public class Matriz
{
    private double [,] matriz;
    public Matriz (int filas, int columnas) {
        this.matriz = new double [filas,columnas];
    } 

    public Matriz (double [,] matriz){
        this.matriz = matriz;
    }


    public double this[int a, int b]
    {
        set => matriz[a, b] = value;
        get => matriz[a, b];
    }


    // se debe asumir que la matriz es cuadrada?? 
    public double [] getDiagonalPrincipal{
        get {
            int tam = this.matriz.GetLength(0);
            double [] vectorReturn = new double[tam];
            for (int i=0; i < tam; i++){
                vectorReturn[i] = this.matriz[i,i];
            }
            return vectorReturn;
        }    
    }

    // se debe asumir que la matriz es cuadrada?? 
    public double [] getDiagonalSecundaria {
        get {
            int tam = this.matriz.GetLength(0); 
            double [] vectorReturn = new double[tam];
            int c = tam-1; // ==>> agarramos el INDICE de la ultima columna
            for (int i=0; i < tam; i++){
                vectorReturn[i] = this.matriz[i,c]; 
                c--;
             }
            return vectorReturn;
        }
    }


}
