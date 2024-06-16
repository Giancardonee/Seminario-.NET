namespace Automotores;

public class Auto
{
    string? _marca;
    int _modelo;
    
    public Auto()
     {
        _marca = "Fiat";
        _modelo = DateTime.Now.Year;
    }

    public Auto(string marca) : this()
    {
        _marca = marca;
    }

    public Auto (string marca, int modelo){
        this._marca = marca; 
        this._modelo = modelo;

    }

    public string ObtenerDescripcion => $"Auto {_marca} {_modelo}";
    
    public string? GetMarca()
    {
        return _marca;
    }
    public int GetModelo()
    {
        return _modelo;
    }

}
