
Highest and Lowest

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Example:

Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

================================================
Мое решение
            var nums = numbers.Split(new Char[] { ' ', ',', '.', ':', '\t' }).Select(c=>Convert.ToInt32(c));
            return string.Format("{0} {1}", nums.Max(), nums.Min()); ;

================================================
  public static string HighAndLow(string numbers)
  {
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
  }
================================================
    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
================================================