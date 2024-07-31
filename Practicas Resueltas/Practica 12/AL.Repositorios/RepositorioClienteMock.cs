using AL.Aplicacion.Entidades;
 using AL.Aplicacion.Interfaces;
 namespace AL.Repositorios;
 public class RepositorioClienteMock : IRepositorioCliente
 {
   private readonly List<Cliente> _listaClietes = new List<Cliente>(){
      new Cliente(){Id=1,Nombre="Alberto",Apellido="García"},
      new Cliente(){Id=2,Nombre="Ana",Apellido="Perez"}
  };//hemos hardcodeado dos clientes en la lista
   static int s_proximoId = 3;
   private Cliente Clonar(Cliente c) //se van a devolver copias de los cliente guardados
   {
       return new Cliente()
       {
           Id = c.Id,
           Nombre = c.Nombre,
           Apellido = c.Apellido
       };
   }
   public void AgregarCliente(Cliente cliente)
   {
       cliente.Id = s_proximoId++;
       _listaClietes.Add(Clonar(cliente));
   }
    public void EliminarCliente(int id)
   {
       var cliente = _listaClietes.SingleOrDefault(c => c.Id == id);
       if (cliente != null)
       {
           _listaClietes.Remove(cliente);
       }
   }
   public Cliente? GetCliente(int id)
   {
       Cliente? c = _listaClietes.SingleOrDefault(c => c.Id == id);
       if (c != null)
       {
           return Clonar(c);
       }
       return null;
   }
   public List<Cliente> GetClientes()
   {
       return _listaClietes.Select(c => Clonar(c)).ToList();
   }
   public void ModificarCliente(Cliente cliente)
   {
       var cli = _listaClietes.SingleOrDefault(c => c.Id == cliente.Id);
       if (cli != null)
       {
           cli.Apellido = cliente.Apellido;
           cli.Nombre = cliente.Nombre;
       }
   }
 }
