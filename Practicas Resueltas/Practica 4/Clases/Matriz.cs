namespace prueba;

public class Matriz
{
    private double [,] matriz;
    
    public Matriz (int filas, int columnas) {
        this.matriz = new double [filas,columnas];
    } 

    public Matriz (double [,] matriz){
        this.matriz = matriz;
    }

    public void setElemento (int fila, int columna, double elemento){
     this.matriz[fila,columna] = elemento;   
    }

    public double getElemento (int fila, int columna){
        return this.matriz[fila,columna];
    }

    public void imprimir (){
        for (int f=0; f < matriz.GetLength(0); f++){
            for (int c=0; c < matriz.GetLength(1); c++){
                Console.WriteLine(matriz[f,c]+" ");
            }
            Console.WriteLine();
        }
    }

    public void imprimir (String formatString){
        for (int f=0; f < matriz.GetLength(0); f++){
            for (int c=0; c < matriz.GetLength(1); c++){
                Console.WriteLine(formatString,matriz[f,c]+" ");
            }
            Console.WriteLine();
        }
    }

    // se debe asumir que la fila es valida? en este caso lo asumo...
    public double[] getFila (int fila){
        double [] arrayFila = new double [matriz.GetLength(1)];
        for (int c = 0; c < matriz.GetLength(1); c++){
            arrayFila[c] = matriz[fila,c];
        }
        return arrayFila;
    }

    public double[] getColumna (int columna){
        double[] arrayColumna = new double [matriz.GetLength(0)];
        for (int f=0; f < matriz.GetLength(0); f++){
            arrayColumna[columna] = matriz[f,columna];
        }
        return arrayColumna;
    }


    // se debe asumir que la matriz es cuadrada?? 
    public double [] getDiagonalPrincipal (){

        int tam = this.matriz.GetLength(0);
        double [] vectorReturn = new double[tam];
        for (int i=0; i < tam; i++){
            vectorReturn[i] = this.matriz[i,i];
        }
    return vectorReturn;
    }
    // se debe asumir que la matriz es cuadrada?? 
    public double [] getDiagonalSecundaria (){
        int tam = this.matriz.GetLength(0); 
        double [] vectorReturn = new double[tam];
        int c = tam-1; // ==>> agarramos el INDICE de la ultima columna
        for (int i=0; i < tam; i++){
            vectorReturn[i] = this.matriz[i,c]; 
            c--;
        }
    return vectorReturn;
    }

    private bool esMatrizCuadrada => this.matriz.GetLength(0) == this.matriz.GetLength(1);
    
    public double [][] devolverArrayDeArray (){
        int filas = matriz.GetLength(0); 
        int columnas = matriz.GetLength(1);
        double [][] vv = new double [filas] [];
        for (int i=0 ; i < filas; i++){
            vv[i] = new double [columnas];
            for (int i2 = 0; i2 < columnas ; i2++){
                vv[i][i2] = matriz[i,i2];
            }
        }
        return vv;
    }
    // {metodos para la suma} 
    public void sumarle (double[,] m2){
        try{
            sumar(m2); 
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }

    private void sumar (double [,] m2){
        if (mismaDimension(m2)){
            int cantF = matriz.GetLength(0); 
            int cantC = matriz.GetLength(1);
            for (int f =0; f < cantF; f++){
                for (int c=0; c < cantC; c++){
                    this.matriz[f,c] += m2[f,c];
                }
            }
        }else{ 
            lanzarExcepcionDimension();
        }     
// ---------------------------------------------------------
    }
    private bool mismaDimension (double [,] m2) => 
    (matriz.GetLength(0) == m2.GetLength(0) && (matriz.GetLength(1) == m2.GetLength (1)) ); 

    public void restarle (double [,] m2){
        try 
        {
            restar(m2); 
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
        }
    }

    private void restar (double [,] m2)
    {
        if (mismaDimension(m2)){
            int cantF = matriz.GetLength(0); 
            int cantC = matriz.GetLength(1);
            for (int f =0; f < cantF; f++){
                for (int c=0; c < cantC; c++){
                    this.matriz[f,c] -= m2[f,c];
                }                        
            }
        }
        else{
            lanzarExcepcionDimension();
        }
    }

    private void lanzarExcepcionDimension(){
        throw new Exception ("Las matrices no coinciden en tamaño");
    }


}
