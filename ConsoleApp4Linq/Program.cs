using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4Linq
{
    
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public Libro(int id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"id: {Id}, Titulo: {Titulo}, Autor: {Autor};";
        }
    }

    //public static class ListExtension
    //{
    //    public static string ToString(this List<T> ls)
    //    {
    //        return "hola";
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>()
            {
                new Libro(1, "Poeta en nueva york", "Federico García Lorca"),
                new Libro(2, "Los asesinos del emperador", "Santiago Posteguillo"),
                new Libro(3, "circo máximo", "Santiago Posteguillo"),
                new Libro(4, "La noche en que Frankenstein leyó el Quijote", "Santiago Posteguillo"),
                new Libro(5, "El origen perdido", "Matilde Asensi")
            };

            var librosDeSantiago = from libro in libros
                                   where libro.Autor == "Santiago Posteguillo"
                                   select libro;
            librosDeSantiago.ToList().ForEach(libro =>
            {
                Console.WriteLine(libro.ToString()); 
            });

            Console.WriteLine("-=---------------");
            librosDeSantiago.ToList().ToString();


        }
    }
}
