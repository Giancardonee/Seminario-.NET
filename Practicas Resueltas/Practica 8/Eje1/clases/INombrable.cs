namespace clases;

public interface INombrable : IComparable<INombrable>
{
    string Nombre { get; }
    string EsUn(); 
    
}
