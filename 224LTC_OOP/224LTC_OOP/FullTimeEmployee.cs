using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224LTC_OOP
{
	class FullTimeEmployee : Employee
	{
		
		public FullTimeEmployee(string name_2150, int paymentPerHour_2150) : base(name_2150, paymentPerHour_2150)
		{

		}

		public override int calculateSalary()
		{
			return 8 * paymentPerHour_2150;
		}
	}
}
