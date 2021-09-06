using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP
{
	public class Sector
	{
		private List<Estante> estantes = new List<Estante>();
		public readonly string Nombre;

		public Sector(string nombre)
		{
			this.Nombre = nombre;
		}

		public bool AñadirEstante(string nuevoEstante)
		{
			// Si hay, al menos, un estante con el mismo nombre, el método no hace nada
			if (estantes.Any(e => e.Nombre == nuevoEstante)) return false;

			estantes.Add(new Estante(nuevoEstante));
			return true;
		}

		public bool AñadirLibro(string estante, Libro libro)
		{
			// Estantes con el nombre del estante a buscar
			Estante[] estantesValidos = estantes.Where(e => e.Nombre == estante).ToArray();

			// Si no hay, se detiene el método
			if (estantesValidos.Length == 0) return false;

			Estante seleccionado = estantesValidos[0];

			seleccionado.AñadirLibro(libro);
			return true;
		}
	}
}