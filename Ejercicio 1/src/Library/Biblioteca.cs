using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP
{
	public class Biblioteca
	{
		private List<Sector> sectores = new List<Sector>();
		public readonly string Nombre;

		public Biblioteca(string nombre)
		{
			this.Nombre = nombre;
		}

		public bool AñadirSector(string nuevoSector)
		{
			// Si hay, al menos, un sector con el mismo nombre, el método no hace nada
			if (sectores.Any(e => e.Nombre == nuevoSector)) return false;

			sectores.Add(new Sector(nuevoSector));
			return true;
		}

		public bool AñadirEstante(string sector, string nuevoEstante)
		{
			// Sectores con el nombre del sector a buscar
			Sector[] sectoresValidos = sectores.Where(s => s.Nombre == sector).ToArray();

			// Si no hay, se detiene el método
			if (sectoresValidos.Length == 0) return false;

			Sector seleccionado = sectoresValidos[0];

			return seleccionado.AñadirEstante(nuevoEstante);
		}

		public bool AñadirLibro(string sector, string estante, Libro libro)
		{
			// Sectores con el nombre del sector a buscar
			Sector[] sectoresValidos = sectores.Where(s => s.Nombre == sector).ToArray();

			// Si no hay, se detiene el método
			if (sectoresValidos.Length == 0) return false;

			Sector seleccionado = sectoresValidos[0];

			return seleccionado.AñadirLibro(estante, libro);
		}
	}
}