using Figuras; 
using Automotores;
internal class Program
{
    private static void Main(string[] args)
    {
        //El constructor de Circulo espera recibir el radio
        List<Circulo> listaCirculos = [
        new Circulo(1.1),
        new Circulo(3),
        new Circulo(3.2)
        ];

        //El constructor de Rectángulo espera recibir la base y la altura
        List<Rectangulo> listaRectangulos = [
        new Rectangulo(3, 4),
        new Rectangulo(4.3, 4.4)
        ];
        //La clase Auto está codificada como la vista en la teoría
        List<Auto> listaAutos = [
        new Auto("Nissan", 2017),
        new Auto("Ford", 2015),
        new Auto("Renault")
        ]; 

        foreach (Circulo c in listaCirculos)
{
    Console.WriteLine($"Área del círculo {c.GetArea}");
    }
    foreach (Rectangulo r in listaRectangulos)
    {
    Console.WriteLine($"Área del rectángulo {r.GetArea}");
    }
    foreach (Auto a in listaAutos)
    {
    Console.WriteLine(a.ObtenerDescripcion);
    }



        Console.ReadKey();
    }
}