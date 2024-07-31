using clases;

internal class Program
{
    private static void Main(string[] args)
    {
        INombrable[] vector = [
            new Persona() {Nombre="Zulema"},
            new Perro() {Nombre="Sultán"},
            new Persona() {Nombre="Claudia"},
            new Persona() {Nombre="Carlos"},
            new Perro() {Nombre="Chopper"},
            ];
        Array.Sort(vector);
        foreach (INombrable n in vector)
        {
            Console.WriteLine($"{n.Nombre}: {n}");
        }
    }
}