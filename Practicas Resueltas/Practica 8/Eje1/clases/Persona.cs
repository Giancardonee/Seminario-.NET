﻿namespace clases;

public class Persona : INombrable
{
    public string Nombre { get; set; } ="";

    public string EsUn()
    {
        return " es una Persona"; 
    }

    public override string ToString()
    {
        return $"{Nombre} {EsUn()}";
    }
    
    public int CompareTo(INombrable? other)
        {
            if (other == null) return 1;
            return string.Compare(this.Nombre, other.Nombre, StringComparison.Ordinal);
        }
}
