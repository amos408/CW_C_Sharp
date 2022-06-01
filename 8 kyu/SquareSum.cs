//Square(n) Sum
//Complete the square sum function so that it squares each number passed into it
//and then sums the results together.

//For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.

int[] n = { 1, 2, 2 };
Console.WriteLine(SquareSum(n));
static int SquareSum(int[] n)
{
    int result = 0;

    foreach (int num in n)
    {
        result += (num * num);
    }

    return result;
}
