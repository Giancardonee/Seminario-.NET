using AL.Aplicacion.Entidades;
 using AL.Aplicacion.Interfaces;
 namespace AL.Aplicacion.UseCases;
 public class ModificarClienteUseCase(IRepositorioCliente repositorio):ClienteUseCase(repositorio)
 {
   public void Ejecutar(Cliente cliente)
  {
      Repositorio.ModificarCliente(cliente);
  }
 }