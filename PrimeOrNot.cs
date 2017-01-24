using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	public class PrimeOrNot
	{
		static void Main(string[] args)
		{
			int a = Convert.ToInt16(Console.ReadLine());
			if (function.bil(a) == true)
			{
				Console.Write("Prime");
			}
			else
			{
				Console.Write("Composed");
			}
			Console.ReadKey();
		}
	}
}
