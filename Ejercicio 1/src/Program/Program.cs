using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca biblioteca = new Biblioteca("Biblioteca de la UCU");
            biblioteca.AñadirSector("A");
            biblioteca.AñadirSector("B");
            biblioteca.AñadirEstante("A", "7");
            biblioteca.AñadirEstante("B", "3");
            biblioteca.AñadirLibro("A", "7", libro1);
            biblioteca.AñadirLibro("B", "3", libro2);
        }
    }
}
