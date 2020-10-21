using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
	class Employee : Firm
	{
		public string name { get; set; }
		public int experience { get; set; }
		public string kharakters { get; set; }


		public static Employee operator +(Employee s)
		{
			return new Employee { name = s.name };
		}
	}
}
