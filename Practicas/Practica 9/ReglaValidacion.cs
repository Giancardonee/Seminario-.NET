 class ReglaValidacion<T>(Func<T, bool> predicado, string mensajeError)
 {
   Func<T, bool> _predicado = predicado;
   public bool Ok(T instancia) => _predicado(instancia);
   public string MensajeError { get; } = mensajeError;
 }
