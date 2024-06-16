using System.IO.Compression;

namespace prueba;

public class Cuenta
{
    private double _monto; 
    private int _titularDni;
    private string? _titularNombre;

    public Cuenta (){
        this._monto=0; 
        this._titularDni=0;
        this._titularNombre="No especificado";
    }

    public Cuenta (int dni) : this(){
        this._titularDni = dni;
    }

    public Cuenta (String nombre) : this(){
        this._titularNombre = nombre; 
    }

    public Cuenta (String nombre, int dni) : this() {
        this._titularNombre = nombre; 
        this._titularDni = dni;
    }

    
    public void Imprimir(){
        String dni = _titularDni == 0 ? "No Especificado" : _titularDni.ToString(); 
        Console.WriteLine($"Nombre: {_titularNombre} Dni: {dni} Monto: {_monto}");
    } 

    // se asume que el monto es >=0
    public void Depositar(double monto){
        this._monto += monto; 
    }

    public void Extraer (double monto){
        if ( (this._monto - monto) >= 0){
            this._monto -= monto;
        }
        else {
            Console.WriteLine("Operacion cancelada, monto insuficiente.");
        }
    }

}
