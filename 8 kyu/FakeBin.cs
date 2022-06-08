//Fake Binary
//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5
//and above with '1'. Return the resulting string.

//Note: input will never be an empty string
public class Kata
{
    public static string FakeBin(string x)
    {
        char[] array = x.ToCharArray();
        string result = "";
        int five = '5';
        for (int i = 0; i < array.Length; i++)
        {
            if (x[i] < five)
            {
                result += 0;
            }
            else
            {
                result += 1;
            }
        }
        return result;
    }
}
