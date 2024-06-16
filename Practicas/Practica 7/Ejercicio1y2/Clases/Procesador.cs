namespace Clases;

public static class Procesador
{
    public static void Alquilar (IAlquilable x, Persona p) => x.SeAlquila(p);  
    public static void Devolver(IAlquilable x, Persona p) => x.SeDevuelve(p); 
    public static void Atender(IAtendible x) => x.SeAtiende();
    public static void Lavar (ILavable x) => x.SeLava();
    public static void Secar (ILavable x) => x.SeSeca();
    public static void Reciclar(IReciclable x) => x.SeRecicla();
    public static void Vender (IVendible x,Persona p) => x.SeVende(p);

}
