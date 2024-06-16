namespace Almacen.Aplicacion;

public class ListarProductosUseCase(IRepositorioProducto repoProducto)
{
    public List<Producto> Ejecutar()
 {  
    return repoProducto.ListarProductos();
  }

}
