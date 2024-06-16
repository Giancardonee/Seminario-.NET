namespace clasesEje8;

public abstract class Empleado
{
    public string Nombre { get; protected set; }
    public int Dni { get; protected set; }
    public DateTime FechaIngreso { get; protected set; }
    public double SalarioBase { get; protected set; }
    public abstract double Salario {get ;}

    public Empleado(string nombre, int dni, DateTime fechaIngreso, double salarioBase)
    {
        Nombre = nombre;
        Dni = dni;
        FechaIngreso = fechaIngreso;
        SalarioBase = salarioBase;
    }
    public int antiguedad {
        get{
        // Calcula la diferencia de años
        int añosTranscurridos = DateTime.Today.Year - FechaIngreso.Year;

        // Ajusta si la fecha actual todavía no ha alcanzado el aniversario
        if (DateTime.Today < FechaIngreso.AddYears(añosTranscurridos))
        {
            añosTranscurridos--;
        }
        return añosTranscurridos;
        }
    }
    public abstract void AumentarSalario(); 
    public override String ToString(){
        return $"Nombre: {Nombre} DNI: {Dni} Antigüedad: {antiguedad} \n Salario base: {SalarioBase} ";
    }
}


