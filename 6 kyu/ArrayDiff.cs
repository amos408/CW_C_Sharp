//Array.diff
//Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

//It should remove all values from list a, which are present in list b keeping their order.

//Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }) => new int[] { 2 }

//If a value is present in b, all of its occurrences must be removed from the other:

//Kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }) => new int[] { 1, 3 }

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        // Your brilliant solution goes here
        // It's possible to pass random tests in about a second ;)
        var returnValues = new int[a.Length];
        var outLength = 0;
        for (var i = 0; i < a.Length; i++)
        {
            if (Contains(a[i], b)) continue;
            returnValues[outLength++] = a[i];
        }
        bool Contains(int a, int[] b)
        {
            foreach (var item in b)
                if (a == item) return true;
            return false;
        }
        var retVal = new int[outLength];
        System.Array.Copy(returnValues, retVal, outLength);
        return retVal;


    }

}

