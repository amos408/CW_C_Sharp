//Integers: Recreation One
//1, 246, 2, 123, 3, 82, 6, 41 are the divisors of number 246. Squaring these divisors we get: 1, 60516, 4, 15129, 9, 6724, 36, 1681. 
//The sum of these squares is 84100 which is 290 * 290.
//Task

//Find all integers between m and n (m and n integers with 1 <= m <= n) such that the sum of their squared divisors is itself a square.

//We will return an array of subarrays or of tuples (in C an array of Pair) or a string. 
//The subarrays (or tuples or Pairs) will have two elements: first the number the squared divisors of which is a square and then the sum of the squared divisors.
//Example:

//list_squared(1, 250) --> [[1, 1], [42, 2500], [246, 84100]]
//list_squared(42, 250) --> [[42, 2500], [246, 84100]]

//The form of the examples may change according to the language, see "Sample Tests".
//Note

//In Fortran - as in any other language - the returned string is not permitted to contain any redundant trailing whitespace: 
//you can use dynamically allocated character strings.


using System;
public class SumSquaredDivisors 
{
	public static string listSquared(long m, long n)
	{
	 if (n-m<0)
            {
                return null;
            }

            if (m<0||n<0)
            {
                return null;
            }
            double sumdivisor = 0;
            string stroutput = "";
            for (long k = m; k <= n; k++)
            {
                for (int l = 1; l <= k; l++)
                {
                    if (k % l == 0)
                    {
                        sumdivisor += l * l;
                    }
                }
                if (Math.Sqrt(sumdivisor) == Convert.ToInt32(Math.Sqrt(sumdivisor)))
                {
                    stroutput += "[" + k + ", " + sumdivisor + "]";
                    stroutput += ", ";
                }
                sumdivisor = 0;
            }
            if (stroutput=="")
            {
                return null;
            }
            return string.Format("[{0}]", stroutput.Remove(stroutput.Length - 2, 2));
	}
}
