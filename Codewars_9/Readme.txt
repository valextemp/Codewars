KATA
Compare two strings by comparing the sum of their values (ASCII character code).
For comparing treat all letters as UpperCase.

Null-Strings should be treated as if they are empty strings.
If the string contains other characters than letters, treat the whole string as it would be empty.

Examples:

"AD","BC" -> equal

"AD","DD" -> not equal

"gf","FG" -> equal

"zz1","" -> equal

"ZzZz", "ffPFF" -> equal

"kl", "lz" -> not equal

null, "" -> equal

Your method should return true, if the strings are equal and false if they are not equal.
-----------------------------------------------
My decision
        public static bool Compare(string s1, string s2)
        {
            
            string mys1, mys2;
            if (String.IsNullOrEmpty(s1)|| ! Regex.IsMatch(s1, "^[A-Za-z]+$")) mys1 = "";
            else mys1 = s1.ToUpper();

            if (String.IsNullOrEmpty(s2)|| !Regex.IsMatch(s2, "^[A-Za-z]+$")) mys2 = "";
            else mys2 = s2.ToUpper();

            Encoding strascii = Encoding.ASCII;

            byte[] mybytes1 = strascii.GetBytes(mys1);
            byte[] mybytes2 = strascii.GetBytes(mys2);

            int sumstr1 = mybytes1.Sum(p => p);
            int sumstr2 = mybytes2.Sum(p => p);

            if (sumstr1 == sumstr2) return true;
            else return false;
        }
------------------------------------------------------
  public static bool Compare(string s1, string s2)
  { 
    if(s1 == null)
    {
      s1 = "";
    }
    if(s2 == null)
    {
      s2 = "";
    }
    if(!s1.All(o => char.IsLetter(o)))
    {
      s1 = "";
    }    
    if(!s2.All(o => char.IsLetter(o)))
    {
      s2 = "";
    }
    return s1.ToUpper().Select(o => (int)o).Sum() == s2.ToUpper().Select(o => (int)o).Sum();
  }


-------------------
public static class Kata
{
  public static bool Compare(string s1, string s2)
  { 
    return CalculateSum(s1) == CalculateSum(s2);    
  }
  
  private static int CalculateSum(string s)
  {
    var sum = 0;
    if (s != null && s.All(char.IsLetter))
      sum = s.Sum(x => (int)Char.ToUpper(x));
      
    return sum;
  }
}