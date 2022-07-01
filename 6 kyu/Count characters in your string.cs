//Count characters in your string
//The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

//What if the string is empty? Then the result should be empty object literal, {}.
using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    // ...
    Dictionary<char, int> dictionary = new Dictionary<char, int>();
        string tmp = new String(str.Distinct().ToArray());
        for (int a = 0; a < tmp.Length; a++)
        {
            int freq = str.Count(s => (s == tmp[a]));
            dictionary.Add(tmp[a], freq);
        }
        return dictionary;
  }
}
