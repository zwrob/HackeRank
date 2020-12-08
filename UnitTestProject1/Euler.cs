using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerLib;

namespace UnitTestProject1
{
    [TestClass]
    public class Euler
    {
        //https://www.hackerrank.com/contests/projecteuler/challenges/euler244/problem
        [TestMethod]
        public void TestSliders()
        {
            // R - red, B- blue, W - white (empty)

            Assert.AreEqual(18553,
               Sliders.CalculateCheckSum(Sliders.CalculateCheckSum(0, 'L'), 'U'));

            Assert.AreEqual(19761398,
                 Sliders.CalculateCheckSum(Sliders.CalculateCheckSum(
                     Sliders.CalculateCheckSum(
                         Sliders.CalculateCheckSum(
                             Sliders.CalculateCheckSum(0, 'L'), 'U'), 'L'), 'U'), 'R'));
        
       
            Assert.AreEqual(18553, Solution.CalculateMinimalLength(
                new List<string>() { "WR", "BB" },
                new List<string>() { "RB", "BW" })); //LU
           
          
           
            Assert.AreEqual(19761398, Solution.CalculateMinimalLength(
                new List<string>() { "WRBB", "RRBB", "RRBB", "RRBB" },
                new List<string>() { "RRBB", "RBBB", "RWRB", "RRBB" }));  //LULUR   ULLUR ??
            
   
              Assert.AreEqual(86665639, Solution.CalculateMinimalLength(
                   new List<string>() { "BBB", "BWR", "RRR" },
                   new List<string>() { "RBR", "BWB", "RBR" })); //DLURRULDDRUL
            
        }

        [TestMethod]
        public void TestPrimeSubsetSums()
        {
        https://www.hackerrank.com/contests/projecteuler/challenges/euler249/problem


            var result = PrimeSubsetSums.GetSubsetsInfo(10, 4);            // 10 4 => 7 3
       

        }
    }
}



