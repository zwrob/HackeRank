using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class MinimumNumber
    {
        public static int minimumNumber(int n, string password)
        {
            // https://www.hackerrank.com/challenges/strong-password/problem

            int min_length = 6;
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int isNumber = (password).Any(h => numbers.Any(x => x == h))?1:0;
            int isLoverCase = (password).Any(h => lower_case.Any(x => x == h))?1:0;
            int isUpperCase = (password).Any(h => upper_case.Any(x => x == h))?1:0;
            int isSpecialChar = (password).Any(h => special_characters.Any(x => x == h))?1:0;

            int il = 4 - isNumber - isLoverCase - isUpperCase - isSpecialChar;
            int uz = (password.Length < min_length) ? min_length - password.Length : 0;

            // Return the minimum number of characters to make the password strong
            return (uz >  il) ? uz : il;
        }
    }
}
