
Create a function that returns the average of an array of numbers ("scores"), rounded to the nearest whole number. 
You are not allowed to use any loops (including for, for/in, while, and do/while loops).

------------------------------------------------------
Мое решение

        public static int Average(int[] scores)
        {
            //return Convert.ToInt32(Math.Round(scores.Average()));

            return (int)Math.Round(scores.Average());
        }

----------------------------------------------------
return Convert.ToInt32(scores.Average());

?? Convert округляет что-ли
----------------------------------------------------
return (int)(scores.Average() + 0.5);
----------------------------------------------------
  public static int Average(int[] scores)   
     => (int)(scores.Average() + 0.5);
----------------------------------------------------