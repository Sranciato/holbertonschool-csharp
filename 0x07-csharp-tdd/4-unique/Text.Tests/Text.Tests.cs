using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    ///<summary>tests for unique char</summary>
    [TestFixture]
    public class Tests
    {
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test1()
		{
			string s = "aab";

            Assert.AreEqual(2, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test2()
		{
			string s = "bbbbbbbbbw";

            Assert.AreEqual(9, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test3()
		{
			string s = "aab";

            Assert.AreNotEqual(9, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test4()
		{
			string s = "";

            Assert.AreEqual(-1, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test5()
		{
			string s = null;

            Assert.AreEqual(-1, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test6()
		{
			string s = "ba";

            Assert.AreEqual(1, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test7()
		{
			string s = "aaaaa";

            Assert.AreEqual(-1, Str.UniqueChar(s));
		}
        ///<summary>tests for unique char</summary>
        [Test]
		public void Test8()
		{
			string s = "bbbbfbbbb";

            Assert.AreEqual(4, Str.UniqueChar(s));
		}
    }
}