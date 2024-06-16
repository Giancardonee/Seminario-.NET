
internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // ejercicio 5
        int[] vector = { 1, 2, 3 };
        vector.ForEach(i => Console.Write(i + ","));
        "Hola Mundo".ForEach(c => Console.Write(c + ","));


        // ejercicio 6
        Console.WriteLine("");
        int[] vector2 = { 1, 2, 3,4,5 };
        vector2.Donde(i => i > 3) // IEnumerable<int> : 4, 5
             .Seleccionar(i => i * 10) // IEnumerable<int> : 40, 50
             .Seleccionar(i => $"({i})") //  IEnumerable<string> : "(40)", "(50)"
             .ForEach(st => Console.WriteLine(st));
        Console.WriteLine("Fin del programa");
        */ 
        
        // ejercicio 9
        var regla1 = new ReglaValidacion<Persona>(p => !string.IsNullOrEmpty(p.Nombre), "Falta el nombre");
        var regla2 = new ReglaValidacion<Persona>(p => p.Edad <= 35, "Edad excedida");
        var regla3 = new ReglaValidacion<Persona>(p => p.Edad >= 18, "Menor de edad");

        var validadorPersona = new Validador<Persona>()
                              .AgregarRegla(regla1)
                              .AgregarRegla(regla2)
                              .AgregarRegla(regla3);

        var pedro = new Persona { Nombre = "Pedro", Edad = 17 };
        var ana = new Persona { Nombre = "", Edad = 16 };
        var maria = new Persona { Nombre = "María", Edad = 44 };
        var jose = new Persona { Nombre = "José", Edad = 30 };

        Validar(pedro, validadorPersona);
        Validar(ana, validadorPersona);
        Validar(maria, validadorPersona);
        Validar(jose, validadorPersona);
    }

    static void Validar(Persona p, Validador<Persona> validadorPersona)
    {
        List<string> listaErrores;
        bool esValido = validadorPersona.Validar(p, out listaErrores);
        Console.WriteLine($"Validando a {p} ==> {esValido}");
        listaErrores.ForEach(st => Console.WriteLine("  * " + st));
    }
    
}