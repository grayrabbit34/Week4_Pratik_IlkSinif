using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Week4_Pratik_IlkSinif
{
	public class Person
	{
		public string name; // isim için field, camelCasing

        public string surname;// soyadı için field

        public DateOnly birthDate; // doğum tarihi için field

        public string Name //isim  için property PascalCasing
		{
			get { return name; } // name  değerini döndür
			set { name = value; } // name'e değer atama
		}

		public string Surname //soyadı için property 
		{
			get { return surname; } // surname değerini döndür
			set { surname = value; } // surname'e değer atama
		}
		

		public DateOnly BirthDate // doğum tarihi için property
		{
			get { return birthDate; } //birthdate değerini döndür
			set { birthDate = value; } //birthname'e değer atama
		}

	}
}
