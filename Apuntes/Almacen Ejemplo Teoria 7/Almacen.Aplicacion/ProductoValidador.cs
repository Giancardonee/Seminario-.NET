namespace Almacen.Aplicacion;

public class ProductoValidador
{
    public bool Validar(Producto producto, out string mensajeError)
    {
        mensajeError = "";
        if (string.IsNullOrWhiteSpace(producto.Nombre))
        {
            mensajeError = "Nombre del producto inválido.\n";
        }
        if (producto.Precio <= 0)
        {
            mensajeError += "El Precio debe ser un valor mayor que cero.\n";
        }
        return (mensajeError == "");
     }
}
