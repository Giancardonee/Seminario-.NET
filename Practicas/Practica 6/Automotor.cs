namespace practica6;

public class Automotor
{
    public string Marca = "";
    public int Modelo;
    public virtual void Imprimir()=> Console.WriteLine($"{Marca} {Modelo}");

}
