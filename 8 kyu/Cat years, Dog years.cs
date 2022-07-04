//Cat years, Dog years
//I have a cat and a dog.

//I got them at the same time as kitten/puppy. That was humanYears years ago.

//Return their respective ages now as [humanYears,catYears,dogYears]

//NOTES:

   // humanYears >= 1
   // humanYears are whole numbers only

//Cat Years

   // 15 cat years for first year
   // +9 cat years for second year
   // +4 cat years for each year after that

//Dog Years

    //15 dog years for first year
   // +9 dog years for second year
   // +5 dog years for each year after that

//References

   // http://www.catster.com/cats-101/calculate-cat-age-in-cat-years
    //http://www.slate.com/articles/news_and_politics/explainer/2009/05/a_dogs_life.html
using System.Linq;
public class Dinglemouse {
  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    // Your code here!
  var catYears = 0;
            var dogYears = 0;
            for (var i = 1; i < humanYears + 1; i++)
            {
                switch (i)
                {
                    case 1:
                        catYears += 15;
                        dogYears += 15;
                        break;
                    case 2:
                        catYears += 9;
                        dogYears += 9;
                        break;
                    default:
                        catYears += 4;
                        dogYears += 5;
                        break;
  }
}
    return new int[] { humanYears, catYears, dogYears };
}
  }
