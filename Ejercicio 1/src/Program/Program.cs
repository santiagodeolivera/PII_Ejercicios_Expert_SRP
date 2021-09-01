using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");
            */
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Sector secA = new Sector("A");
            Sector secB = new Sector("B");
            secA.AñadirEstante("7");
            secB.AñadirEstante("3");
            secA.AñadirLibro("7", libro1);
            secB.AñadirLibro("3", libro2);
        }
    }
}
