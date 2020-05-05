using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
		public void Test1()
		{
			string s = "aab";

            Assert.AreEqual(2, Str.UniqueChar(s));
		}
        [Test]
		public void Test2()
		{
			string s = "bbbbbbbbbw";

            Assert.AreEqual(9, Str.UniqueChar(s));
		}
        [Test]
		public void Test3()
		{
			string s = "aab";

            Assert.AreNotEqual(9, Str.UniqueChar(s));
		}
    }
}