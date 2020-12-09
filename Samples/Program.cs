using System;
using Samples.ReduceIfs;

namespace Samples
{
	class Program
	{
		static void Main(string[] args)
		{
			var classWithIfs = new ClassWithIfs();
			var classWithoutIfs = new ClassWithoutIfs();

			var r1 = classWithIfs.Calculate(1, 2, "+");
			var r2 = classWithoutIfs.Calculate(new AddOperation(1, 2));

			Console.WriteLine("r1 = {0}", r1);
			Console.WriteLine("r2 = {0}", r2);
		}
	}
}
