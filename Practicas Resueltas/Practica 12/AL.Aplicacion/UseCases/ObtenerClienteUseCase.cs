using AL.Aplicacion.Entidades;
 using AL.Aplicacion.Interfaces;
 namespace AL.Aplicacion.UseCases;
 public class ObtenerClienteUseCase(IRepositorioCliente repositorio):ClienteUseCase(repositorio)
 {
  public Cliente? Ejecutar(int id)
  {
     return Repositorio.GetCliente(id);
  }
 }