﻿using Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        Auto auto = new Auto();
        Libro libro = new Libro();
        Persona persona = new Persona();
        Perro perro = new Perro();
        Pelicula pelicula = new Pelicula();
        Procesador.Alquilar(pelicula, persona);
        Procesador.Alquilar(libro, persona);
        Procesador.Atender(persona);
        Procesador.Atender(perro);
        Procesador.Devolver(pelicula, persona);
        Procesador.Devolver(libro, persona);
        Procesador.Lavar(auto);
        Procesador.Reciclar(libro);
        Procesador.Reciclar(auto);
        Procesador.Secar(auto);
        Procesador.Vender(auto, persona);
        Procesador.Vender(perro, persona);
        Procesador.Lavar(perro);
        Procesador.Secar(perro);
        PeliculaClasica peliculaClasica = new PeliculaClasica();
        Procesador.Alquilar(peliculaClasica, persona);
        Procesador.Devolver(peliculaClasica, persona);
        Procesador.Vender(peliculaClasica, persona);
    }
}