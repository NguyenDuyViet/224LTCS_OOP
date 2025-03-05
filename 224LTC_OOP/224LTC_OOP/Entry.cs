using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224LTC_OOP
{
	public class Entry
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Nguyen Duy Viet msv: 22115053122150");
			PartTimeEmployee employee1 = new PartTimeEmployee("Thanh", 4500, 7);
			Console.WriteLine("Name: " + employee1.getName());
			Console.WriteLine("Lalary per day: " + employee1.calculateSalary());

			FullTimeEmployee employee2 = new FullTimeEmployee("Phuong", 65000);
			Console.WriteLine("Name: " + employee2.getName());
			Console.WriteLine("Lalary per day: " + employee2.calculateSalary());
		}
	}
}
