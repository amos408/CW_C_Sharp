//Mumbling
//This time no story, no theory. The examples below show you how to write function accum:
//Examples:

//accum("abcd")-> "A-Bb-Ccc-Dddd"
//accum("RqaEzty")-> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
//accum("cwAt")-> "C-Ww-Aaa-Tttt"

//The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;
using System.Collections.Generic;
using System.Linq;

public class Accumul
{
    public static String Accum(string s)
    {
        // your code
        var normalList = s.ToList();
        var mumblingList = "";
        for (int i = 0; i < normalList.Count; i++)
        {
            if (i > 0)
            {
                mumblingList += '-';
            }
            for (int j = 1; j <= i + 1; j++)
            {
                if (j == 1)
                {
                    mumblingList += Char.ToUpper(normalList[i]);
                }
                else
                {
                    mumblingList += Char.ToLower(normalList[i]);
                }
            }
        }
        return mumblingList.ToString();
    }
}
