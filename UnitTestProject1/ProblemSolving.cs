using System;
using System.Collections.Generic;
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
        {///nieksońcozne !!!
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

        [TestMethod]
        public void TestMatrixRotation()
        {
            // https://www.hackerrank.com/challenges/matrix-rotation-algo/problem


            string res2 = MatrixRotation.matrixRotation(
               new List<List<int>>()
           {
                new List<int>(){38950343, 46927501, 52732087, 79096784, 99768969, 87107645, 10655095, 46677242, 33633183, 16379998, 27254248, 42691669, 36996828, 39112247, 88842074, 24498867, 24431906, 2183515, 24518860, 8314921, 61842591, 4075781, 78546289, 38723163, 54296259, 58332834, 72221222, 76060312, 73789550, 83838565, 39249266, 60702778, 26036952, 90167124, 27699771},
                new List<int>(){16890510, 84763994, 62683333, 36330960, 52963972, 67006619, 29122446, 93405938, 99753158, 83562860, 7054176, 92077306, 4345791, 75012462, 89936676, 68000196, 62575180, 35614647, 28391955, 42040554, 30306484, 34913710, 2884941, 53777471, 963349, 70026715, 64164289, 79955530, 74725282, 20357033, 38623679, 66125006, 73439290, 30872072, 57168246},
                new List<int>(){99414907, 74527659, 20102991, 68221497, 15715836, 47037040, 94668793, 38183872, 65506647, 73462209, 53396698, 25954898, 59140985, 32091272, 81005196, 42056652, 74616728, 96357248, 63835792, 67447027, 38683492, 80044320, 8263886, 12287085, 85600270, 20185300, 6188842, 40727578, 56937426, 43100133, 71397805, 74205441, 30524204, 3263549, 65617321},
                new List<int>(){12791945, 56974984, 19553267, 43711417, 81809847, 38184584, 58918402, 73754269, 19237784, 3764818, 33621057, 29600133, 68345843, 28601713, 84942306, 11092771, 29557082, 87544699, 23607103, 20201108, 55705511, 61696137, 85170914, 10137374, 45661875, 94851660, 37224143, 28908570, 2724302, 48348702, 44508728, 98771569, 76221723, 17912741, 57904517},
                new List<int>(){8706735, 97453699, 57047755, 43731381, 48294456, 54391094, 98099423, 10926264, 78273507, 23487841, 74326637, 25392625, 15579738, 91504754, 24148953, 23183065, 8808037, 55422220, 2194578, 47164195, 93810141, 84319296, 30855604, 35426054, 48535293, 63522577, 764127, 83936671, 11240401, 18378950, 68935044, 90805728, 86840745, 32682148, 9278234},
                new List<int>(){65009421, 42441944, 35083780, 41764933, 48542010, 84988319, 25745337, 3740135, 57697810, 21482385, 55038384, 29704849, 96550594, 25374716, 46276002, 74349120, 33685751, 71492951, 75259269, 47698699, 61853746, 56273236, 80848410, 30945346, 79451758, 90076980, 82818953, 6862713, 42603635, 34020227, 25939062, 69666819, 37096588, 55012614, 52505001},
                new List<int>(){75762177, 10546334, 89597290, 29497431, 59021632, 86900651, 39702792, 21072044, 62079995, 57754642, 71562357, 2273815, 28578645, 7939247, 52825694, 55664954, 60380224, 86457800, 42282778, 78982370, 68479663, 78083813, 41638747, 58991300, 36669712, 65796279, 29423523, 34377500, 72976303, 99717277, 23389311, 78821178, 45460956, 4329732, 59643645},
                new List<int>(){84321666, 86194626, 62491641, 34285202, 14392555, 39290, 12126244, 26454124, 26922815, 33330680, 79455933, 10478125, 37300277, 41637573, 51261012, 69190192, 3819479, 45480086, 57882634, 40513196, 69446833, 78221446, 98552569, 65051316, 86691725, 11304763, 91120738, 53697639, 85633000, 88588317, 69364683, 61161903, 19076056, 13739959, 82803519},
                new List<int>(){33841807, 33366533, 12483205, 76302053, 98605911, 68562392, 34944673, 39739191, 72825638, 87466960, 72434531, 21627929, 5388429, 69451246, 37698618, 94812528, 3443661, 82044693, 98013027, 47231792, 60277409, 60949252, 56448839, 46225605, 75981731, 87432480, 48216855, 90975187, 54478649, 50981117, 56209117, 24405786, 67978531, 24647410, 52686070},
                new List<int>(){23243869, 3097132, 60696192, 42515278, 22909051, 41625048, 34961554, 17449558, 62534378, 83337900, 29747706, 30639539, 54646830, 88255096, 47159363, 65907570, 93903144, 1399516, 87422869, 7267015, 19764438, 24380035, 10059961, 10752972, 39106282, 15013312, 19701899, 42837490, 96499250, 28720802, 82882472, 77534353, 52258178, 63581494, 87324151},
                new List<int>(){37755625, 91346726, 34690382, 1032465, 25564074, 39837005, 82867258, 74939433, 10672680, 9862449, 17779854, 59887687, 36874462, 28865278, 6190029, 76422675, 62042896, 34428245, 42301094, 84161170, 68925174, 32093600, 79078957, 46430019, 71157668, 20310550, 56939340, 75419884, 91764932, 84015676, 39337774, 73274535, 9860620, 46339150, 53568652},
                new List<int>(){55336990, 55350739, 46542796, 39474174, 53199594, 81146709, 81534392, 28783468, 47255908, 57727656, 8165819, 13446816, 71128103, 15848500, 54011009, 12599333, 63644237, 9772340, 25432869, 14683063, 17965691, 85612722, 33486691, 53775941, 92015724, 17203398, 80570802, 77320611, 99535960, 15370209 ,63723500, 76215634, 96898348, 25561726, 54078615},
                new List<int>(){77626125, 17225955, 3502408, 6230294, 45890440, 80426701, 98863935, 36120902, 97543984, 2541996, 82907528, 81554238, 12750828, 69136727, 27632013, 25549470, 17328300, 95799755, 81169470, 19489574, 17069254, 19541016, 87002310, 90381267, 89211288, 43589430, 63032667, 54531734, 74671653, 60062711, 90617014, 88560734, 69061170, 95822938, 63385964},
                new List<int>(){27904950, 80510009, 11906194, 11001213, 72834700, 7982675, 6712459, 43958651, 82491474, 95029102, 56442671, 62128677, 28567949, 30813309, 50195710, 31931780, 61990524, 2780558, 41688759, 64879495, 18327591, 53468499, 44740362, 23667883, 50635116, 57737366, 45456230, 41092665, 32064365, 16088734, 90483634, 61762241, 14794853, 54761946, 37751016},
                new List<int>(){6916800, 66718961, 33941839, 23785234, 18618791, 32792836, 91680892, 9999605, 61162042, 84081561, 93033496, 19271750, 44753832, 24264830, 11419555, 63680959, 89356321, 20732633, 42379145, 94450630, 65030632, 15388760, 38649547, 75942078, 29209101, 48893183, 59890390, 96971840, 31028061, 1312714, 50402324, 84775311, 68185691, 12012533, 93829018},
                new List<int>(){79615390, 62746400, 92109555, 45101941, 61335591, 68895313, 83921794, 6781796, 93082789, 37853418, 53586262, 99470136, 61975664, 42995983, 25381115, 74109108, 51670577, 11673865, 79276139, 27756850, 77577467, 19319390, 36848871, 13820636, 51904093, 76125493, 54942002, 82749303, 22757777, 76918850, 31300901, 49831132, 49209530, 90804743, 1918495},
                new List<int>(){63012775, 32526254, 38743488, 75927905, 35549466, 22702488, 44425201, 10621617, 15816183, 58973982, 46641778, 76539161, 89754035, 83171064, 29811982, 553637, 50195617, 85570690, 63397526, 3500645, 21707681, 4331694, 40655128, 68131471, 99608922, 1648704, 72501480, 83035711, 47465250, 82435779, 23225179, 8666688, 98634485, 4651809, 71361633},
                new List<int>(){2716447, 24326862, 54305299, 41254015, 23825243, 63167325, 22727130, 78655392, 4973828, 55390112, 28875495, 37184119, 50895077, 88565632, 75238148, 1526714, 67454777, 41154226, 12322752, 97989359, 75189696, 5200857, 13776988, 33331317, 94054306, 80129376, 31855821, 58770443, 11915871, 55864506, 11254100, 77633152, 65450803, 45404222, 88248491},
                new List<int>(){2328139, 68833569, 84484742, 91643453, 19155178, 22972630, 89124861, 92191840, 37917430, 26036236, 50605927, 17961383, 87387637, 84624143, 51838240, 64544198, 67385670, 94179595, 9084225, 81057184, 83556907, 17099263, 78653234, 5556927, 71897925, 37487010, 19452400, 56793626, 66658091, 12610715, 69172447, 63154172, 77452579, 72859638, 74406930},
                new List<int>(){ 24195466, 19254443, 44363078, 13147904, 55344681, 82390365, 81419403, 61870543, 62144103, 38746759, 99497737, 88813748, 26843833, 55099909, 93812968, 83352, 67196515, 24815879, 13337908, 25849048, 44983993, 35122953, 35604833, 10175640, 60106567, 58741395, 53761820, 59923877, 64991337, 95862345, 44087642, 15675488, 73626867, 95299715, 29532209 }
           }
               , 20);

            //https://hr-testcases-us-east-1.s3.amazonaws.com/8965/output02.txt?AWSAccessKeyId=AKIAR6O7GJNX5DNFO3PV&Expires=1600114429&Signature=U9BArZKKYLg%2B56ha%2FRynePVSjrc%3D&response-content-type=text%2Fplain

            //61842591 4075781 78546289 38723163 54296259 58332834 72221222 76060312 73789550 83838565 39249266 60702778 26036952 90167124 27699771 57168246 65617321 57904517 9278234 52505001 59643645 82803519 52686070 87324151 53568652 54078615 63385964 37751016 93829018 1918495 71361633 88248491 74406930 29532209 95299715

            string res0 = MatrixRotation.matrixRotation(
              new List<List<int>>()
          {
                new List<int>(){1, 2, 3, 4},
                new List<int>(){7, 8, 9, 10},
                new List<int>(){13, 14, 15, 16},
                new List<int>(){ 19, 20, 21, 22 },
                new List<int>(){ 25, 26, 27, 28 }
          }, 7);



            string res1 =  MatrixRotation.matrixRotation(
                new List<List<int>>()
            {
                new List<int>(){1, 2, 3, 4},
                new List<int>(){5, 6, 7, 8},
                new List<int>(){9, 10, 11, 12},
                new List<int>(){13, 14, 15, 16 }
            }, 2);

        }

        [TestMethod]
        public void TestInsertionSort1()
        {
            //  https://www.hackerrank.com/challenges/insertionsort1/problem
            InsertionSort.insertionSort1(5, new int[] { 2, 4, 6, 8, 3 });
            InsertionSort.insertionSort1(14, new int[] { 1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 87, 23, });
            InsertionSort.insertionSort1(10, new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 });

        }

        [TestMethod]
        public void TestOrganizingContainers()
        {
            //https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
          
            
              Assert.AreEqual("Possible", 
                  OrganizingContainers.organizingContainers(new int[][]{new int[]{ 1, 1 },new int[]{ 1, 1 }}));
         
              Assert.AreEqual("Impossible", 
                  OrganizingContainers.organizingContainers(new int[][] { new int[] { 0, 2 }, new int[] { 1, 1 } }));
         
              Assert.AreEqual("Impossible",
                  OrganizingContainers.organizingContainers(new int[][] { new int[] { 1, 3, 1 }, new int[] { 2, 1, 2 }, new int[] { 3, 3 ,3 } }));

         
            Assert.AreEqual("Possible",
                OrganizingContainers.organizingContainers(new int[][] { new int[] { 0, 2, 1 }, new int[] { 1, 1, 1 }, new int[] { 2, 0, 0 } }));

            Assert.AreEqual("Possible",
                OrganizingContainers.organizingContainers(new int[][] { new int[] { 999336263, 998799923 }, new int[] { 998799923, 999763019 } }));

            

            Assert.AreEqual("Possible",
                 OrganizingContainers.organizingContainers(new int[][] 
                 { new int[] { 997612619, 934920795, 998879231, 999926463 }, 
                   new int[] { 960369681, 997828120, 999792735, 979622676 },
                   new int[] { 999013654, 998634077, 997988323, 958769423 } ,
                   new int[] { 997409523, 999301350, 940952923, 993020546 } 
                        }));

        }

        //https://www.hackerrank.com/challenges/frequency-queries/problem


        [TestMethod]
        public void TestHappyLadybugs()
        {

            //https://www.hackerrank.com/challenges/happy-ladybugs/problem

            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("RBY_YBR"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("X_Y__X"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("__"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("B_RRBR"));

            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("AABBC"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("AABBC_C"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("_"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("DD__FQ_QQF"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("AABCBC"));

            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("_"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("RBRB"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("RRRR"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("BBB"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("BBB_"));

            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("G"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("GR"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("_GR_"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("_R_G_"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("R_R_R"));
            Assert.AreEqual("YES", HappyLadybugs.happyLadybugs("RRGGBBXX"));
            Assert.AreEqual("NO", HappyLadybugs.happyLadybugs("RRGGBBXY"));

        }

    }
}
