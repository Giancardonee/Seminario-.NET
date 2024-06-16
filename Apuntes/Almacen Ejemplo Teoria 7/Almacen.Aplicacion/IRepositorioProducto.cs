namespace Almacen.Aplicacion;

public interface IRepositorioProducto
{
    void AgregarProducto(Producto producto);
    List<Producto> ListarProductos();
    Producto ? GetProducto (int id); 
    void ModificarProducto(Producto producto); 
    void EliminarProducto(int id);
}
