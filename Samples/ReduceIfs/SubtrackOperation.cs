namespace Samples.ReduceIfs
{
	public class SubtrackOperation : IOperation
	{
		private readonly int _b;
		private readonly int _a;

		public SubtrackOperation(int a, int b)
		{
			this._a = a;
			this._b = b;
		}

		public int Apply()
		{
			return _a - _b;
		}
	}
}