Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

The binary number returned should be a string.
======================================
пояснение
Console.WriteLine(Convert.ToString(25, 2));//первая цифра число, вторая система исчисления
Проблема в том, что это можно сделать только для систем исчисления 2,8,10,16.
https://social.msdn.microsoft.com/Forums/ru-RU/f3e732e5-ec07-4d2f-9602-7e1441fdcb58/-c-?forum=programminglanguageru
======================================
МОЕ РЕШЕНИЕ
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
			//
        }
=======================================
Лучшее решение
public static class Kata
{
  public static string AddBinary(int a, int b) =>
    Convert.ToString(a + b, 2);
}
========================================