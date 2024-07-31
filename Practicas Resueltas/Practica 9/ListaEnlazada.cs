 class ListaEnlazada<T>
{
    private Nodo<T> _inicio = null;
    public void AgregarAdelante(T value)
    {
        if(_inicio == null){
             _inicio = new Nodo<T>(value);
             return;
        }
        else{
            Nodo<T> nodoAuxiliar = _inicio;
            _inicio = new Nodo<T>(value);
            _inicio.Proximo = nodoAuxiliar;
        }
    }
    public void AgregarAtras(T value)
    {
        if(_inicio == null){
             _inicio = new Nodo<T>(value);
             return;
        }
        else{
            Nodo<T> nodoAuxiliar = _inicio;
            while(nodoAuxiliar.Proximo != null){
                nodoAuxiliar = nodoAuxiliar.Proximo;
            }
            nodoAuxiliar.Proximo = new Nodo<T>(value);
        }
    }
    public IEnumerator<T> GetEnumerator(){
        Nodo<T> nodoAuxiliar = _inicio;
        List<T> lista = new List<T>();
        while(nodoAuxiliar.Proximo!=null){
            lista.Add(nodoAuxiliar.Valor);
            nodoAuxiliar = nodoAuxiliar.Proximo;
        }
        lista.Add(nodoAuxiliar.Valor);
        return lista.GetEnumerator();
    }
}