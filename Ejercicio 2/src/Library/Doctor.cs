using System;

namespace Library
{
	/// <summary>
	/// Esta clase representa a un doctor.
	/// Tiene la responsabilidad de almacenar toda la información asociada a el,
	/// como el nombre y la especialidad.
	/// </summary>
	public class Doctor
	{
        public readonly string Name;
        public readonly string Specialty;

		public Doctor(string name, string specialty)
		{
			if(string.IsNullOrEmpty(name)) throw new ArgumentException("Name is required");
			if(string.IsNullOrEmpty(specialty)) throw new ArgumentException("Specialty is required");
			
            this.Name = name;
            this.Specialty = specialty;
		}
	}
}