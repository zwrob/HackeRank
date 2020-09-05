using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolvingLib;

namespace UnitTestProject1
{
    [TestClass]
    public class ProblemSolving
    {


        [TestMethod]
        public void TestGridSearch()
        {
            //https://www.hackerrank.com/challenges/the-grid-search/problem
            /*
            string[] G = new string[]
            {
                "7283455864",
                "6731158619",
                "8988242643",
                "3830589324",
                "2229505813",
                "5633845374",
                "6473530293",
                "7053106601",
                "0834282956",
                "4607924137"
            };

            string[] P = new string[]
            {
                "9505",
                "3845",
                "3530"
            };
            */
            
            string[] G = new string[]
          {
                "123412",
                "561212",
                "123634",
                "7812889"
          };

            string[] P = new string[]
            {
                "12",
                "34"
            };
            
            /*
            string[] G = new string[]
            {
                "111111111111111",
                "111111111111111",
                "111111011111111",
                "111111111111111",
                "111111111111111"
            };

            string[] P = new string[]
           {
                "11111",
                "11111",
                "11110"
           };
            */

            string result = GridSearch.Search(G, P);

        }

        [TestMethod]
        public void TestSherlockAndAnagrams()
        {
            // https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem

            Assert.AreEqual(4, SherlockAndAnagrams.sherlockAndAnagrams("abba"));
            Assert.AreEqual(0, SherlockAndAnagrams.sherlockAndAnagrams("abcd"));

            Assert.AreEqual(3,SherlockAndAnagrams.sherlockAndAnagrams("ifailuhkqq"));
            Assert.AreEqual(10, SherlockAndAnagrams.sherlockAndAnagrams("kkkk"));
        }

        [TestMethod]
        public void TestFairRations()
        {
            //https://www.hackerrank.com/challenges/fair-rations/problem
            Assert.AreEqual(4,FairRations.fairRations(new int[] { 4,5,6,7}));
            Assert.AreEqual(4, FairRations.fairRations(new int[] { 2, 3, 4, 5, 6 }));
        }
    }
}
