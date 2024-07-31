namespace practica5;

public class ListaDePersonas
{
    private List<Persona> lista; 

    public ListaDePersonas(){
        lista = new List<Persona> ();
    }

    public void Agregar (Persona p){
        this.lista.Add(p);
    }   

    public Persona this [int dni]{
        get
        {
            foreach (Persona per in lista){
                if (per.Dni == dni) return per; 
            }
            return new Persona();
        }
    }

    public List<String> this[char c]{
        get
        {
            List<string> listaReturn = new List<string>();
            foreach (Persona p in lista){
                if (p.Nombre[0] ==c) listaReturn.Add(p.Nombre);
            }
            return listaReturn;
        }
    }

}
