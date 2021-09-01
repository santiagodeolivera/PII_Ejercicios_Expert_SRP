using System;
using System.Collections.Generic;

namespace SRP
{
	public class Estante
	{
		private List<Libro> libros = new List<Libro>();
		public readonly string Nombre;

		public Estante(string nombre)
		{
			this.Nombre = nombre;
		}

		public void AñadirLibro(Libro libro)
		{
			libros.Add(libro);
		}
	}
}