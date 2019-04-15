using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeAlgorithmsLib.Tests
{
    [TestClass]
    public class EasyAlgorithmsTests
    {
        [TestMethod]
        public void NumJewelsInStones_aA_aAAbbbb_3returned()
        {
            // arrange
            var J = "aA";
            var S = "aAAbbbb";
            var expected = 3;

            // act
            EasyAlgorithms alg = new EasyAlgorithms();
            int actual = alg.NumJewelsInStones(J, S);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumJewelsInStones_z_ZZ_0returned()
        {
            // arrange
            var J = "z";
            var S = "ZZ";
            var expected = 0;

            // act
            EasyAlgorithms alg = new EasyAlgorithms();
            int actual = alg.NumJewelsInStones(J, S);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumUniqueEmails()
        {
            // arrange
            var s = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            var expected = 2;

            // act
            EasyAlgorithms alg = new EasyAlgorithms();
            int actual = alg.NumUniqueEmails(s);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
