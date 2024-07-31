namespace prueba;


/* 
    No entendi si los metodos: 
        getDiscriminante y getCantidadDeRaices 
    tienen que ser privados para accederlos dentro del imprimirRaices
    o si tienen que ser publico en caso de que se quieran usar fuera de la clase



*/
public class Ecuacion2
{
    private double a, b , c; 

    public Ecuacion2 (double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    
    public double getDiscriminante => (Math.Pow(b,2)) - 4*a*c;

    public int getCantidadDeRaices (){
        double cantRaices = this.getDiscriminante;
        return cantRaices <0 ? 0 : cantRaices == 0 ? 1 : 2;
    }

    public void imprimrRaices (){
        String mensaje;
        int cantRaices = this.getCantidadDeRaices();
        if (cantRaices == 0 )mensaje = "No existen soluciones reales para esta ecuación.";
        else if (cantRaices == 1) {
            double x1 =(-b + Math.Sqrt(getDiscriminante)) / (2 * a);
            mensaje = $"La unica raiz es: {x1}";
        }
        else {
            double x1 = (-b + Math.Sqrt(getDiscriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(getDiscriminante)) / (2 * a);
            mensaje = $"Las racies son: \n {x1} y \n {x2}";
        }
        Console.WriteLine(mensaje);
    }
}
