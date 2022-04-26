using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_sobaka
{
	internal class Program
	{
		static void Main(string[] args)
		{
			(string Name, string Type, double Age, int NameCount) Pet;

			Console.WriteLine("Введите имя питомца");
			Pet.Name = Console.ReadLine();
			Pet.NameCount = Pet.Name.Length;

			Console.WriteLine("Введите вид питомца");
			Pet.Type = Console.ReadLine();

			Console.WriteLine("Введите возраст питомца");
			Pet.Age = double.Parse(Console.ReadLine());

			Console.WriteLine("У вас есть собака по кличке персик и ему 13 лет верно?");
			String yes = Console.ReadLine();

		}
	}
}
