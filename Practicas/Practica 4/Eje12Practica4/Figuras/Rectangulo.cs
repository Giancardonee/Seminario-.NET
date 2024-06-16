namespace Figuras;

public class Rectangulo
{
    private double _base; 
    private double _altura; 

    public Rectangulo(double b, double a){
        this._base = b; 
        this._altura = a;
    }

    public double GetArea => _base * _altura;

}
