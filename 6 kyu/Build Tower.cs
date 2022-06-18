//Build Tower
//Build a pyramid-shaped tower given a positive integer number of floors.
//A tower block is represented with "*" character.

//For example, a tower with 3 floors looks like this:

//[
//  "  *  ",
//  " *** ",
//  "*****"
//]

//And a tower with 6 floors looks like this:

//[
//  "     *     ",
//  "    ***    ",
//  "   *****   ",
//  "  *******  ",
//  " ********* ",
//  "***********"
//]

//Go challenge Build Tower Advanced once you have finished this :)

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] lin = new string[nFloors];

        for (int i = 0; i < nFloors; i++)
        {
            lin[i] += new string(' ', nFloors - i - 1);
            lin[i] += new string('*', i + i + 1);
            lin[i] += new string(' ', nFloors - i - 1);
        }

        return lin;
    }
}
