using AL.Aplicacion.Interfaces;
 namespace AL.Aplicacion.UseCases;
 public class EliminarClienteUseCase(IRepositorioCliente repositorio):ClienteUseCase(repositorio)
 {
   public void Ejecutar(int id)
  {
      Repositorio.EliminarCliente(id);
  }
 }