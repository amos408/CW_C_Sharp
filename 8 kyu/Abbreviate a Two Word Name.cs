//Abbreviate a Two Word Name
//Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

//The output should be two capital letters with a dot separating them.

//It should look like this:

//Sam Harris => S.H

//patrick feeney => P.F

public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] sN = name.Split(" ");
            string fIn = sN[0].Substring(0, 1);
            string sIn = sN[1].Substring(0, 1);

            return fIn.ToUpper() + "." + sIn.ToUpper();
  }
}
