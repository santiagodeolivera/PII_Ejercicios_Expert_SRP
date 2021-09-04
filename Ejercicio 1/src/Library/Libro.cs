using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        // El libro no debe tener la responsabilidad de almacenar información sobre su misma ubicación.
        // En su lugar, se crean clases asociadas a la jerarquía de la ubicación de un libro

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }
}
