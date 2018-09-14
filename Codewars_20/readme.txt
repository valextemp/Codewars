
Beginner Series #3 Sum of Numbers

Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. 
If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples
GetSum(1, 0) == 1   // 1 + 0 = 1
GetSum(1, 2) == 3   // 1 + 2 = 3
GetSum(0, 1) == 1   // 0 + 1 = 1
GetSum(1, 1) == 1   // 1 Since both are same
GetSum(-1, 0) == -1 // -1 + 0 = -1
GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2
================================================

Мое решение
не очень изящно
     public int GetSum(int a, int b)
     {
            int minint, countint;
            if (a == b) return a;


            else if (a>b)
            {
                minint = b;
                countint = a - b+1;
            }
            else
            {
                minint = a;
                countint = b -a+1;
            }

            return Enumerable.Range(minint,countint).Sum();
     }
=========================================
???? А как же если они равны
    return (a + b) * (Math.Abs(a - b) + 1) / 2;

=============================
        return Enumerable.Range(Math.Min(a,b), Math.Max(b,a)-Math.Min(b,a)+1).Sum();
