using System;

namespace ConsoleApp6Unit
{
	class Company
	{
		public string Type;
		public string Name;
	}

	class Department
	{
		public Company Company;
		public City City;
	}

	class City
	{
		public string Name;
	}
	class Program
	{
		static void Main(string[] args)
		{
			var department = GetCurrentDepartment();
		}

		static Department GetCurrentDepartment()
		{
			if (Department?.Company?.Type == "Банк" && Department?.City?.Name == "Санкт-Перербург")
			{
				Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
			}
		}
	}
}
