//Friend or Foe?
//Make a program that filters a list of strings and returns a list with only your friends name in it.

//If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

//Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

//i.e.

//friend ["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]

//Note: keep the original order of the names in the output.

using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    // Good luck!
    int friendCount = 0;
            for (int i = 0; i <= names.Length - 1; i++)
            {
                if (names[i].Length == 4)
                    friendCount++;
            }
            int j = 0;
            string[] friends = new string[friendCount];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                if (names[i].Length == 4)
                {
                    friends[j] = names[i];
                    j++;
                }
            }
            return friends;

  }
}
