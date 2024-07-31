namespace practica5;

public class Persona
{
    public string Nombre {get; set;}
    public char Sexo {get; set;}
    public int Dni {get; set;}
    public DateTime fechaNacimiento{get; set;}  

    public Persona(string nombre, int dni, char sexo, DateTime fechaNac){
        Nombre = nombre;
        Sexo = sexo;
        Dni = dni; 
        fechaNacimiento = fechaNac; 
    }
    public Persona(){
        Nombre = "Indefinido";
    }

    public int Edad {
        get {
            DateTime hoy = DateTime.Now;
            int edadCalculada = (hoy.Year - fechaNacimiento.Year );
            return edadCalculada;
        }
    }

    public object this[int i]
    {
        get
        {
            if (i == 0) return Nombre;
            else if (i == 1) return Sexo;
            else if (i == 2) return Dni;
            else if (i == 3) return fechaNacimiento;
            else if (i == 4) return Edad;
            else return null;
        }
        set
        {
            if (i == 0) Nombre = (string)value;
            else if (i == 1) Sexo = (char)value;
            else if (i == 2) Dni = (int)value;
            else if (i == 3) fechaNacimiento = (DateTime)value;
        }
    }


    
}   

