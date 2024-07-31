namespace Figuras;

public class Circulo
{
    double _radio;

    public Circulo(double radio){
        this._radio = radio;
    }

    public double GetArea => Math.PI * Math.Pow(_radio, 2);

}
