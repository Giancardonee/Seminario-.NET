class Validador<T> 
{

      private List<ReglaValidacion<T>> listaReglas = new List<ReglaValidacion<T>>();

    public Validador<T> AgregarRegla(ReglaValidacion<T> regla)
    {
        listaReglas.Add(regla);
        return this;
    }

    public bool Validar(T objeto, out List<string> errores)
    {
        errores = new List<string>();
        int cantErrores = 0;
        
        foreach (var regla in listaReglas)
        {
            if (!regla.Ok(objeto))
            {
                errores.Add(regla.MensajeError);
                cantErrores++;
            }
        }
        return cantErrores == 0;
    }
}