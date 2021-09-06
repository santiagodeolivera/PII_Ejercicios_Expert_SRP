using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
	/// <summary>
	/// Esta clase representa a un paciente.
	/// Tiene la responsabilidad de almacenar información respecto a un paciente,
	/// como el nombre, la edad, la cédula de identidad y el número de teléfono.
	/// </summary>
	public class Patient
	{
    	public readonly string Name;
    	public readonly byte Age;
    	public readonly string Id;
    	public readonly string PhoneNumber;

        private static List<string> ids = new List<string>();

		public Patient(string name, byte age, string id, string phoneNumber)
		{
            if(string.IsNullOrEmpty(name)) throw new ArgumentException("A name is required");

            if(string.IsNullOrEmpty(id)) throw new ArgumentException("Id is required");
            if(ids.Contains(id)) throw new ArgumentException($"There's already a patient with the id \"{id}\"");
			if(!IdUtils.IdIsValid(id))
				throw new ArgumentException("The Id must be valid");
			
            if(string.IsNullOrEmpty(phoneNumber)) throw new ArgumentException("Phone number is required");
            if(phoneNumber.Where(c => Char.IsDigit(c)).Count() != 10)
                throw new ArgumentException("A phone number must have 10 digits");

	        this.Name = name;
            this.Age = age;
            this.Id = id;
            ids.Add(id);
            this.PhoneNumber = phoneNumber;
		}
	}
}