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
			string s = "abcba";

            Assert.AreEqual(true, Str.IsPalindrome(s));
		}
        [Test]
		public void Test2()
		{
			string s = "abccba";

            Assert.AreEqual(true, Str.IsPalindrome(s));
		}
        [Test]
		public void Test3()
		{
			string s = "abdcba";

            Assert.AreEqual(false, Str.IsPalindrome(s));
		}
        [Test]
		public void Test4()
		{
			string s = "aBcbA";

            Assert.AreEqual(true, Str.IsPalindrome(s));
		}
        [Test]
		public void Test5()
		{
			string s = "ab,cb  a";

            Assert.AreEqual(true, Str.IsPalindrome(s));
		}
        [Test]
		public void Test6()
		{
			string s = "";

            Assert.AreEqual(true, Str.IsPalindrome(s));
		}
    }
}