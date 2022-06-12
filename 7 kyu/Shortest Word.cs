//Shortest Word
//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types.

public class Kata
{
    public static int FindShort(string s)
    {
        string[] words = s.Split(" ");
        string shortest = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }
        }
        return shortest.Length;
    }
}
