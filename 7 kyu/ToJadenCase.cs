//Jaden Casing Strings
//Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010)
//and After Earth (2013). Jaden is also known for some of his philosophy that he delivers
//via Twitter.When writing on Twitter, he is known for almost always capitalizing every word.
//For simplicity, you'll have to capitalize each word, check out how contractions are expected
//to be in the example below.

//Your task is to convert strings to how they would be written by Jaden Smith.The strings
//are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

//Example:

//Not Jaden - Cased: "How can mirrors be real if our eyes aren't real"
//Jaden - Cased:     "How Can Mirrors Be Real If Our Eyes Aren't 

using System;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string[] words = phrase.Split(' ');
        string text = string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            char firstLetter = char.ToUpper(word[0]);
            text += Convert.ToString(firstLetter);

            for (int p = 1; p < word.Length; p++)
            {
                text += word[p];
            }
            text += " ";
        }
        text = text.Trim();
        return text;
    }
}
