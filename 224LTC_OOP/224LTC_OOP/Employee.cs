using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224LTC_OOP
{
	abstract class Employee : IEmployee
	{
		protected String name_2150 { set; get; }
		protected int paymentPerHour_2150 {set; get;}
		public Employee(String name, int paymentPerHour)
		{
			this.name_2150 = name;
			this.paymentPerHour_2150 = paymentPerHour;
		}
		public virtual int calculateSalary()
		{
			return 0;
		}

		public string getName()
		{
			return name_2150;
		}
	}
}