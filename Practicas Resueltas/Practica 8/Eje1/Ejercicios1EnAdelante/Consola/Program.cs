using clases;
namespace Consola
{
    internal class Program
    {
        delegate int FuncionEntera(int n);

        private static void Main(string[] args)
        {
            
            Console.WriteLine("Ejercicio 7: ");
            int[] vector = [1, 2, 3, 4, 5];
            vector.Print("Valores iniciales: ");
            var vector2 = vector.Seleccionar(n => n * 3);
            vector2.Print("Valores triplicados: ");
            vector.Seleccionar(n => n * n).Print("Cuadrados: ");
            
            Console.WriteLine("========================");
            Console.WriteLine("Ejercicio 8: "); 

            vector.Print("Valores inicialeS: ");
            vector.Donde(n => n % 2 == 0 ).Print("Pares: ");
            vector.Donde(n => n % 2 == 1).Seleccionar(n => n * n).Print("Impares al cuadrado: ");
        }
    }
}