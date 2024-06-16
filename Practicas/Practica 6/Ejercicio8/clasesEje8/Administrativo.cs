namespace clasesEje8;

public class Administrativo : Empleado
{    
        public double Premio { get; set; }

        public Administrativo(string nombre, int dni, DateTime fechaIngreso, double salarioBase)
            : base(nombre, dni, fechaIngreso, salarioBase){}
            
        public override double Salario
        {
            get
            {
                return SalarioBase + Premio; 
            }
        } 

        public override void AumentarSalario()
        {
            double aumento = SalarioBase * (antiguedad * 0.01);
            SalarioBase += aumento;
        }

    public override string ToString()
    {
        return "Administrativo "+base.ToString()+$"Salario: {Salario}";
    }

}
