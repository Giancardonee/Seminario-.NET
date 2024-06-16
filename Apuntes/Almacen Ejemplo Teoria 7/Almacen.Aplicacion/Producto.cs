namespace Almacen.Aplicacion;

public class Producto
{
public int Id { get; set; }
 public string Nombre { get; set; } = "";
 public double Precio { get; set; }
 public override string ToString()
 {
 return $"{Nombre} ${Precio})";
 }

}
