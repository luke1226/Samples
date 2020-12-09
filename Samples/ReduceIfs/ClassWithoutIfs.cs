namespace Samples.ReduceIfs
{
	public class ClassWithoutIfs
	{
		public int Calculate(IOperation operation)
		{
			return operation.Apply();
		}
	}
}