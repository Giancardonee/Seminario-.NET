using AL.Aplicacion.Entidades;
 using AL.Aplicacion.Interfaces;
 namespace AL.Aplicacion.UseCases;
 public class AgregarClienteUseCase(IRepositorioCliente repositorio):ClienteUseCase(repositorio)
 {
   public void Ejecutar(Cliente cliente)
   {
       //aca podríamos insertar código de validación de cliente
       // si el cliente no existe lo agregamos, y si el cliente es valido tamb podriamos chequear.
       Repositorio.AgregarCliente(cliente);
   }
 }
