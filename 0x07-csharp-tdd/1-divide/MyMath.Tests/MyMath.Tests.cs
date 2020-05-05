using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
		public void Test1()
		{
			int[,] matrix = new int[2, 2] { { 9, 3 }, { 6, 12 } };

			Assert.AreEqual(new int[2, 2] { { 3, 1 }, { 2, 4 } }, Matrix.Divide(matrix, 3));
		}
        [Test]
		public void Test2()
		{
			int[,] matrix = new int[2, 2] { { 9, 3 }, { 6, 12 } };

			Assert.AreEqual(null, Matrix.Divide(matrix, 0));
		}
        [Test]
		public void Test3()
		{
			Assert.AreEqual(null, Matrix.Divide(null, 2));
		}
        [Test]
		public void Test4()
		{
            int[,] matrix = new int[2, 2] { { 0, 3 }, { 6, 12 } };

			Assert.AreEqual(new int[2, 2] { { 0, 1 }, { 2, 4 } }, Matrix.Divide(matrix, 3));
		}
    }
}