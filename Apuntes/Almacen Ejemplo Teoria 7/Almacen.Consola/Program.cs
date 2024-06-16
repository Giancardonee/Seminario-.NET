using Almacen.Aplicacion;        
using Almacen.Repositorios;
internal class Program
{
    
    private static void Main(string[] args)
    {
        /* 
        //configuro las dependencias
        IRepositorioProducto repo = new RepositorioProductoTXT();
        //creo los casos de uso
        var agregarProducto = new AgregarProductoUseCase(repo,new ProductoValidador());
        var listarProducto = new ListarProductosUseCase(repo);
        //ejecuto los casos de uso
        agregarProducto.Ejecutar(new Producto() { Nombre="Yerba",Precio=1000});
        agregarProducto.Ejecutar(new Producto() { Nombre="Azúcar",Precio=500});
        var lista = listarProducto.Ejecutar();
        foreach(Producto p in lista)
        {
        Console.WriteLine(p);
        }
        */ 
        //creo el caso de uso
    var agregarProducto = new AgregarProductoUseCase(new RepositorioProductoTXT(),new ProductoValidador());
    try
    {
       agregarProducto.Ejecutar(new Producto());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    }
}