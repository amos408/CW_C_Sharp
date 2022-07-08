//Complete the function/method so that it returns the url with anything after the anchor (#) removed.
//Examples
//"www.codewars.com#about" --> "www.codewars.com"
//"www.codewars.com?page=1" -->"www.codewars.com?page=1"

public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    // TODO: complete
  int index = url.IndexOf("#");
  if (index > 0)
      url = url.Substring(0, index);
      return url;
  }
}
