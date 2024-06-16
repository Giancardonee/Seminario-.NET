namespace clasesEje8;

public class Vendedor : Empleado
{
    public double Comision {get; set;}

    public Vendedor (string nombre, int dni, DateTime fechaIngreso, double SalarioBase) 
    : base(nombre,dni,fechaIngreso,SalarioBase){}
    
    public override double Salario {
        get{
            return SalarioBase + Comision;
        }
    }
    public override void AumentarSalario()
    {
        int porcentajeAumento = antiguedad < 10? 5 : 10;
        double aumento = SalarioBase * (porcentajeAumento / 100.0);
        SalarioBase += aumento;
    }

    public override string ToString()
    {
        return "Vendedor "+base.ToString()+$"Salario: {Salario}";
    }


}
