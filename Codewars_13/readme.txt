
Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

each taken only once - coming from s1 or s2. #Examples: ``` a = "xyaabbbccccdefww" b = "xxxxyyyyabklmopq" longest(a, b) -> "abcdefklmopqwxy"
a = "abcdefghijklmnopqrstuvwxyz" longest(a, a) -> "abcdefghijklmnopqrstuvwxyz" ```
--------------------------------------------
Мое решение

        public static string TwoToOne(string s1, string s2)
        {
            char[] myChars;

            string tempStr = s1 + s2;
            var myResult = tempStr.Distinct().OrderBy(c => c);
            return string.Join("", myResult);

            //myChars = tempStr.ToCharArray();
            //var myResult = myChars.Distinct().OrderBy(c=>c).ToString();
        }


-------------------------------------------------
Лучшие решения

  public static string Longest (string s1, string s2) 
  {
        return new string ((s1 +s2).Distinct().OrderBy(x=>x).ToArray ());
  }

-----
    public static string Longest(string s1, string s2) 
    {
        return string.Concat((s1 + s2).Distinct().OrderBy(c => c));
    }
------