using AL.Aplicacion.Interfaces;
 namespace AL.Aplicacion.UseCases;
 public abstract class ClienteUseCase(IRepositorioCliente repositorio)
 {
   protected IRepositorioCliente Repositorio { get; } = repositorio;
 }