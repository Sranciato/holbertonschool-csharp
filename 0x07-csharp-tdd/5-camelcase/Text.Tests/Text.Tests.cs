using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    ///<summary>tests for camelcase char</summary>
    [TestFixture]
    public class Tests
    {
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test1()
		{
			string s = "aab";

            Assert.AreEqual(1, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test2()
		{
			string s = "heyThere";

            Assert.AreEqual(2, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test3()
		{
			string s = "";

            Assert.AreEqual(0, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test4()
		{
			string s = null;

            Assert.AreEqual(0, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test5()
		{
			string s = "stupidcomputerthinksthisisonlyonewordlol";

            Assert.AreEqual(1, Str.CamelCase(s));
		}
    }
}