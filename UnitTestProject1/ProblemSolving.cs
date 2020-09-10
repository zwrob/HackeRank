using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

          //  Assert.AreEqual(4, SherlockAndAnagrams.sherlockAndAnagrams("abba"));
        //  Assert.AreEqual(0, SherlockAndAnagrams.sherlockAndAnagrams("abcd"));

          //  Assert.AreEqual(3, SherlockAndAnagrams.sherlockAndAnagrams("ifailuhkqq"));
            Assert.AreEqual(10, SherlockAndAnagrams.sherlockAndAnagrams("kkkk"));
        }

        [TestMethod]
        public void TestFairRations()
        {
            //https://www.hackerrank.com/challenges/fair-rations/problem
            Assert.AreEqual(4,FairRations.fairRations(new int[] { 4,5,6,7}));
            Assert.AreEqual(4, FairRations.fairRations(new int[] { 2, 3, 4, 5, 6 }));
        }

        [TestMethod]
        public void TestGemStones()
        {

            Assert.AreEqual(2, Gemstones.gemstones(new string[] {"abcdde","baccd","eeabg" })); ;
        }

        [TestMethod]
        public void TestStringFunctionCalculation()
        {
            // https://www.hackerrank.com/challenges/string-function-calculation/problem
        //  Assert.AreEqual(12, StringFunctionCalculation.MaxValue("banana"));
            //  Assert.AreEqual(12, StringFunctionCalculation.MaxValue("aaaaaa"));
            //  Assert.AreEqual(9, StringFunctionCalculation.MaxValue("abcabcddd"));

         /*
            Assert.AreEqual(9000, StringFunctionCalculation.MaxValue(
            "abaabbaaaaabbbbbbbabbbbaaaaaabbaababaaabaaabbbbaabbaaaaaaaaabbaaaabbababbaaabbababbaabaabbbbabbbaaaaaabbaaabbaaaaaaabbababaabbbbbbbbbbbbbbaabbabbbbaaababbaaaababbbbaaabbbbbaaabbabbabbbababbbbbaaaabababbbbbaaaaabababbbbabbbabaaababbaabbbbabbaabbaaaaabbbabaababbabbaababbbababaabaabbbaaababbabbbaabbaaababbbbaaaaabaababaabababbaabaabaabbbabbaabaaababbaabbbabbaaaabaaabbbbbbbabbabbaaaaabbaabbabbabaaabbbabababbbbbabaaabababbbbbababababababababbaababababababbbababaaabbaaababababbbaabbbabababaaabbaaaaaabaaababbbbbaaaaabaaaababaabaabbbabbbbbaaaaabaabbabbbabaababbbabbbababbaababaaabbbbaaaaaaabbabababaaaaaababbbbbabaabaababbabaaabbbbabaaaaaabbbbabbbbababaaaaaababbaababbabbaaaabaaaababbabbbbbbbabbbbaaabbabaaaaababbbaaaabbbaabbaaaaaaaaababaabbababbabbbaabbbabbbbabbaababbaaaababbbaaaababaaaabaabbabaaabaabaaabbbbbbbabbbabbbbbabbbbbbbbaabaaabbbabababaabbaaaabbabababbaabbaaabbbbaabaaabaabbaabbaabbabbbababababbaabbaabbbabbbababaaabbbabaaaabbbaaaaabbbaaababbbbbaabbaababbaaaabaabaabaabbbbbaaaabbbbaaabaabaaabaabbaaaaabbbbbbbabbbbaaaaaabbaababaaabaaabbbbaabbaaaaaaaaabbaaaabbababbaaabbababbaabaabbbbabbbaaaaaabbaaabbaaaaaaabbababaabbbbbbbbbbbbbbaabbabbbbaaababbaaaababbbbaaabbbbbaaabbabbabbbababbbbbaaaabababbbbbaaaaabababbbbabbbabaaababbaabbbbabbaabbaaaaabbbabaababbabbaababbbababaabaabbbaaababbabbbaabbaaababbbbaaaaabaababaabababbaabaabaabbbabbaabaaababbaabbbabbaaaabaaabbbbbbbabbabbaaaaabbaabbabbabaaabbbabababbbbbabaaabababbbbbababababababababbaababababababbbababaaabbaaababababbbaabbbabababaaabbaaaaaabaaababbbbbaaaaabaaaababaabaabbbabbbbbaaaaabaabbabbbabaababbbabbbababbaababaaabbbbaaaaaaabbabababaaaaaababbbbbabaabaababbabaaabbbbabaaaaaabbbbabbbbababaaaaaababbaababbabbaaaabaaaababbabbbbbbbabbbbaaabbabaaaaababbbaaaabbbaabbaaaaaaaaababaabbababbabbbaabbbabbbbabbaababbaaaababbbaaaababaaaabaabbabaaabaabaaabbbbbbbabbbabbbbbabbbbbbbbaabaaabbbabababaabbaaaabbabababbaabbaaabbbbaabaaabaabbaabbaabbabbbababababbaabbaabbbabbbababaaabbbabaaaabbbaaaaabbbaaababbbbbaabbaababbaaaabaabaabaabbbbbaaaabbbbaaabaabaaabaabbaaaaabbbbbbbabbbbaaaaaabbaababaaabaaabbbbaabbaaaaaaaaabbaaaabbababbaaabbababbaabaabbbbabbbaaaaaabbaaabbaaaaaaabbababaabbbbbbbbbbbbbbaabbabbbbaaababbaaaababbbbaaabbbbbaaabbabbabbbababbbbbaaaabababbbbbaaaaabababbbbabbbabaaababbaabbbbabbaabbaaaaabbbabaababbabbaababbbababaabaabbbaaababbabbbaabbaaababbbbaaaaabaababaabababbaabaabaabbbabbaabaaababbaabbbabbaaaabaaabbbbbbbabbabbaaaaabbaabbabbabaaabbbabababbbbbabaaabababbbbbababababababababbaababababababbbababaaabbaaababababbbaabbbabababaaabbaaaaaabaaababbbbbaaaaabaaaababaabaabbbabbbbbaaaaabaabbabbbabaababbbabbbababbaababaaabbbbaaaaaaabbabababaaaaaababbbbbabaabaababbabaaabbbbabaaaaaabbbbabbbbababaaaaaababbaababbabbaaaabaaaababbabbbbbbbabbbbaaabbabaaaaababbbaaaabbbaabbaaaaaaaaababaabbababbabbbaabbbabbbbabbaababbaaaababbbaaaababaaaabaabbabaaabaabaaabbbbbbbabbbabbbbbabbbbbbbbaabaaabbbabababaabbaaaabbabababbaabbaaabbbbaabaaabaabbaabbaabbabbbababababbaabbaabbbabbbababaaabbbabaaaabbbaaaaabbbaaababbbbbaabbaababbaaaabaabaabaabbbbbaaaabbbbaaabaabaaabaabbaaaaabbbbbbbabbbbaaaaaabbaababaaabaaabbbbaabbaaaaaaaaabbaaaabbababbaaabbababbaabaabbbbabbbaaaaaabbaaabbaaaaaaabbababaabbbbbbbbbbbbbbaabbabbbbaaababbaaaababbbbaaabbbbbaaabbabbabbbababbbbbaaaabababbbbbaaaaabababbbbabbbabaaababbaabbbbabbaabbaaaaabbbabaababbabbaababbbababaabaabbbaaababbabbbaabbaaababbbbaaaaabaababaabababbaabaabaabbbabbaabaaababbaabbbabbaaaabaaabbbbbbbabbabbaaaaabbaabbabbabaaabbbabababbbbbabaaabababbbbbababababababababbaababababababbbababaaabbaaababababbbaabbbabababaaabbaaaaaabaaababbbbbaaaaabaaaababaabaabbbabbbbbaaaaabaabbabbbabaababbbabbbababbaababaaabbbbaaaaaaabbabababaaaaaababbbbbabaabaababbabaaabbbbabaaaaaabbbbabbbbababaaaaaababbaababbabbaaaabaaaababbabbbbbbbabbbbaaabbabaaaaababbbaaaabbbaabbaaaaaaaaababaabbababbabbbaabbbabbbbabbaababbaaaababbbaaaababaaaabaabbabaaabaabaaabbbbbbbabbbabbbbbabbbbbbbbaabaaabbbabababaabbaaaabbabababbaabbaaabbbbaabaaabaabbaabbaabbabbbababababbaabbaabbbabbbababaaabbbabaaaabbbaaaaabbbaaababbbbbaabbaababbaaaabaabaabaabbbbbaaaabbbbaaabaabaaabaabbaaaaabbbbbbbabbbbaaaaaabbaababaaabaaabbbbaabbaaaaaaaaabbaaaabbababbaaabbababbaabaabbbbabbbaaaaaabbaaabbaaaaaaabbababaabbbbbbbbbbbbbbaabbabbbbaaababbaaaababbbbaaabbbbbaaabbabbabbbababbbbbaaaabababbbbbaaaaabababbbbabbbabaaababbaabbbbabbaabbaaaaabbbabaababbabbaababbbababaabaabbbaaababbabbbaabbaaababbbbaaaaabaababaabababbaabaabaabbbabbaabaaababbaabbbabbaaaabaaabbbbbbbabbabbaaaaabbaabbabbabaaabbbabababbbbbabaaabababbbbbababababababababbaababababababbbababaaabbaaababababbbaabbbabababaaabbaaaaaabaaababbbbbaaaaabaaaababaabaabbbabbbbbaaaaabaabbabbbabaababbbabbbababbaababaaabbbbaaaaaaabbabababaaaaaababbbbbabaabaababbabaaabbbbabaaaaaabbbbabbbbababaaaaaababbaababbabbaaaabaaaababbabbbbbbbabbbbaaabbabaaaaababbbaaaabbbaabbaaaaaaaaababaabbababbabbbaabbbabbbbabbaababbaaaababbbaaaababaaaabaabbabaaabaabaaabbbbbbbabbbabbbbbabbbbbbbbaabaaabbbabababaabbaaaabbabababbaabbaaabbbbaabaaabaabbaabbaabbabbbababababbaabbaabbbabbbababaaabbbabaaaabbbaaaaabbbaaababbbbbaabbaababbaaaabaabaabaabbbbbaaaabbbbaaabaabaa"
            ));
            */
            new ProblemSolvingLib.SuffixTree.SuffixTree("aaaaaa$").Visualize();
        }

        
        [TestMethod]
        public void TestAlternatingCharacters()
        {
            // https://www.hackerrank.com/challenges/alternating-characters/problem
            Assert.AreEqual(3,AlternatingCharacters.alternatingCharacters("AAAA"));
            Assert.AreEqual(4, AlternatingCharacters.alternatingCharacters("BBBBB"));
            Assert.AreEqual(0, AlternatingCharacters.alternatingCharacters("ABABABAB"));
            Assert.AreEqual(0, AlternatingCharacters.alternatingCharacters("BABABA"));
            Assert.AreEqual(4, AlternatingCharacters.alternatingCharacters("AAABBB"));
        }

        [TestMethod]
        public void TestBiggerIsdGreater()
        {
            // https://www.hackerrank.com/challenges/bigger-is-greater/problem
            Assert.AreEqual("ba", BiggerIsGreater.biggerIsGreater("ab"));
            Assert.AreEqual("no answer", BiggerIsGreater.biggerIsGreater("bb"));
            Assert.AreEqual("hegf", BiggerIsGreater.biggerIsGreater("hefg"));
            Assert.AreEqual("dhkc", BiggerIsGreater.biggerIsGreater("dhck"));
            Assert.AreEqual("hcdk", BiggerIsGreater.biggerIsGreater("dkhc")); //!!!
        }

        [TestMethod]
        public void TestAbsolutePermutation()
        {
            // https://www.hackerrank.com/challenges/absolute-permutation/problem
           // można dodać tes funkcji  AbsolutePermutation.absolutePermutation
        }


    }
}


