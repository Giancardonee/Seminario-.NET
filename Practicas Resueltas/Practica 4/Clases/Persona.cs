public class Persona
{
    private String nombre;
    private String dni;
    private int edad;
    public Persona(String nombre, String dni, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }

    public String imprimir => $"{this.nombre}   {this.edad}   {this.dni}";

    public bool esMayorQue(Persona p)
    {
        return this.edad > p.edad;
    }
}