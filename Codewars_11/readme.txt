Find the number with the most digits.

If two numbers in the argument array have the same number of digits, return the first one in the array.
--===================================================
МОЕ РЕШЕНИЕ
        public static int FindLongest(int[] number)
        {
            int maxlenth = 0;
            int templenth = 0;
            int index = 0;
            for (int i=0; i<number.Length; i++)
            {
                templenth = Convert.ToString(number[i]).Length;
                if (templenth>maxlenth)
                {
                    maxlenth = templenth;
                    index = i;
                }
            }
            return number[index];
      }


=====================================================
ДРУГИЕ РЕШЕНИЯ
самое умное
    public static int FindLongest(int[] N)
    {
        return N.OrderByDescending(X => X.ToString().Length).First();
    }
----------
менее умное
  public static int FindLongest(int[] number)
    => number.Aggregate(0, (s,n)=> $"{s}".Length < $"{n}".Length ? n : s);
==================================================