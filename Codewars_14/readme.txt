
Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. For example:

  sumDigits(10);  // Returns 1
  sumDigits(99);  // Returns 18
  sumDigits(-32); // Returns 5
Let's assume that all numbers in the input will be integer values.
------------------------------------------------------------------
Мое решение

        public static int SumDigits(int number)
        {
            if (number>=0)
            {
                return number.ToString().ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
            }
               
            else
            {
                return number.ToString().Trim('-').ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
            }
        }


------------------------------------------------------
решения их

return (int)number.ToString().Sum(x => char.IsNumber(x) ? char.GetNumericValue(x) : 0);

----

return Math.Abs(number).ToString().Select(n => int.Parse(n.ToString())).Sum();

