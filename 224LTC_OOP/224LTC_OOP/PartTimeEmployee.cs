using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224LTC_OOP
{
	class PartTimeEmployee : Employee
	{
		private int workingHours_2150 { set; get; }
		public PartTimeEmployee(string name_2150, int paymentPerHour_2150, int workingHours_2150)
	: base(name_2150, paymentPerHour_2150)
		{
			this.workingHours_2150 = workingHours_2150;
		}

		public override int calculateSalary()
		{
			return workingHours_2150 * paymentPerHour_2150;
		}
	}
}
