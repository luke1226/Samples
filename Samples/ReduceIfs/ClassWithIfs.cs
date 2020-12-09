using System;

namespace Samples
{
	public class ClassWithIfs
	{
		public int Calculate(int a, int b, string operation)
		{
			if (operation == "+")
				return a + b;

			if (operation == "-")
				return a - b;

			throw new NotSupportedException();
		}
	}
}