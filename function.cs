using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab1
{
	public class function

	{
		public static Boolean bil(int n)
		{
			Boolean ok = true;
			for (int i = 3; i < n; i++)
			{
				if (n < 100 && n % i == 0 || n % 2 == 0 || n % 3 == 0)
					ok = false;
				else if (n > 100 && n % Convert.ToInt16(Math.Pow(i, 2)) != 0)
					ok = false;
				else
					ok = true;
			}
			return ok;
				
		}



	}
}
