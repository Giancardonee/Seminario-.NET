namespace Almacen.Aplicacion;

public class AgregarProductoUseCase(IRepositorioProducto repoProducto, ProductoValidador validadorProducto)
{
    public void Ejecutar(Producto producto)
    {
        if (!validadorProducto.Validar(producto,out string mensajeError))
        {
            throw new Exception(mensajeError);
        }
        repoProducto.AgregarProducto(producto);
    }
}
