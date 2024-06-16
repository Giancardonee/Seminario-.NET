namespace Almacen.Repositorios;
using Almacen.Aplicacion;
public class RepositorioProductoTXT : IRepositorioProducto
{
    readonly string _nombreArch = "productos.txt";
    static int s_idProducto = 0 ;
    public void AgregarProducto (Producto prod)
    {
        using var sw = new StreamWriter(_nombreArch,true);
        prod.Id = ++s_idProducto;
        sw.WriteLine(prod.Id); 
        sw.WriteLine(prod.Nombre);
        sw.WriteLine(prod.Precio);
    }
    public List<Producto> ListarProductos()
    {
        var resultado = new List<Producto>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var producto = new Producto(); 
            producto.Id = int.Parse(sr.ReadLine() ?? ""); 
            producto.Nombre = sr.ReadLine() ?? "";
            producto.Precio = int.Parse(sr.ReadLine() ?? "");
            resultado.Add(producto); 
        }
        return resultado;
    }
    
    public Producto? GetProducto(int id)
    {
        try 
        {
            var listaProd = ListarProductos();
            foreach (Producto p in listaProd)
            {
                if (p.Id == id)
                    return p;
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error. Argumento no valido."); 
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: "+e);
        }        
        return null;
    }

    public void ModificarProducto(Producto producto)
    {
        try
        {
            var listaProductos  = ListarProductos();
            int indiceActual=0;
            bool encontre = false;
            while ( (indiceActual < listaProductos.Count()&& (!encontre)) )
            {
                if (listaProductos[indiceActual].Id == producto.Id)
                {
                    listaProductos[indiceActual].Nombre = producto.Nombre;
                    listaProductos[indiceActual].Precio = producto.Precio;
                    encontre=true;
                }
                indiceActual++;
            }
            if (encontre) actualizarArchivo (listaProductos);
            // volver a escribir todo el archivo con la nueva lista

        }   
        catch (Exception e)
        {
            Console.WriteLine("Error al modificar el producto. Error "+e);
        }             
    }

    public void EliminarProducto(int id)
    {
        try
        {
            var listaProductos = ListarProductos();
            int indiceActual = 0; 
            bool encontre = false;
            while (indiceActual < listaProductos.Count && !encontre)
            {
                if (listaProductos[indiceActual].Id == id)
                {
                    listaProductos.RemoveAt(indiceActual);
                    encontre=true;  
                }
                indiceActual++;
            }
            if (encontre) actualizarArchivo(listaProductos); 
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al eliminar producto. Error "+e.Message);
        }
    }



    private void actualizarArchivo(List <Producto> listaProductos)
    {
        try
        {
            if (File.Exists(_nombreArch))
            {
                File.Delete(_nombreArch); 
                foreach(Producto p in listaProductos)
                {
                    AgregarProducto(p); 
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al actualizar el archivo. Error "+e.Message); 
        }
    }

}
