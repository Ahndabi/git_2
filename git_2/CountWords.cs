using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_2
{
	internal class CountWords
	{
		static void Main()
		{
			string str = Console.ReadLine();
			string[] str2 = str.Split();
			int a = str2.GetLength(0);
			Console.WriteLine(a);
		}

	}
}
