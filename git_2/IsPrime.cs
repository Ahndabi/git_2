using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_2
{
	internal class IsPrime
	{
		static bool _IsPrime(int n)
		{
			bool IsPrime = true;

			for (int i = 2; i < n; ++i)
			{
				if (n % i == 0)
				{
					IsPrime = false;
					break;
				}
			}

			return IsPrime;
		}

	}
}
