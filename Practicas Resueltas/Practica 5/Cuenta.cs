namespace practica5;

public class Cuenta
{
    private static int s_cantCuentas = 0;
    private static double s_cantDepositos =0;
     private static double s_totalDepositado = 0;
    private static int s_cantExtracciones = 0;
    private static double s_totalExtraido = 0;
    private static double s_saldo = 0;
    private static int s_extraccionesDenegadas=0;
    private static List<Cuenta> s_listaCuentas = new List<Cuenta>();
    private double _monto { get; set; } = 0;
    private int _idCuenta { get; set; } = ++s_cantCuentas;

    public static List<Cuenta> GetCuentas{
        get{
            return new List<Cuenta>(s_listaCuentas);
        }
    }

    public Cuenta (){
        Console.WriteLine("Se creo la cuenta Id=" + _idCuenta);
        s_listaCuentas.Add(this);
    }

    public Cuenta Depositar (double cantidad){
        _monto+=cantidad;
        s_cantDepositos++;
        s_totalDepositado+=cantidad;
        Console.WriteLine($"Se depositó {cantidad} en la cuenta {_idCuenta} (Saldo={_monto})");
        return this;
    }

    public Cuenta Extraer(double cantidad){
        if (cantidad <= _monto){
            _monto-= cantidad;
            s_cantExtracciones++;
            s_totalExtraido+=cantidad;
            Console.WriteLine($"Se estrajo {cantidad} de la cuenta {_idCuenta} (Saldo={_monto})");
        }else{
            s_extraccionesDenegadas++;
            Console.WriteLine("Operacion Denegada - Salgo Insuficiente.");
        }
        return this;
    }

    public static void ImprimirDetalle(){
        s_saldo = s_totalDepositado - s_totalExtraido;
        Console.WriteLine($"CUENTAS CREADAS: {s_cantCuentas}");
        Console.Write    ($"DEPOSITOS      : {s_cantDepositos}   "); Console.WriteLine($"- Totao depositado: {s_totalDepositado}");
        Console.Write    ($"EXTRACCIONES   : {s_cantExtracciones}    "); Console.WriteLine($"- Total extraido: {s_totalExtraido}");
        Console.Write     ("               :      "); Console.WriteLine($"- Saldo: {s_saldo}");
        Console.WriteLine($"* Se denegaron {s_extraccionesDenegadas} extracciones por falta de fondos.");
    }
    

}
