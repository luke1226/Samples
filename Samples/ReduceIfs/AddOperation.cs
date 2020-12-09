namespace Samples.ReduceIfs
{
	public class AddOperation : IOperation
	{
		private readonly int _b;
		private readonly int _a;

		public AddOperation(int a, int b)
		{
			this._a = a;
			this._b = b;
		}
		public int Apply()
		{
			return _a + _b;
		}
	}
}