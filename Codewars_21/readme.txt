
Simple Fun #176: Reverse Letter

Task
Given a string str, reverse it omitting all non-alphabetic characters.

Example
For str = "krishan", the output should be "nahsirk".

For str = "ultr53o?n", the output should be "nortlu".

Input/Output
[input] string str

A string consists of lowercase latin letters, digits and symbols.

[output] a string
=======================================================
Мое решение
        public static string ReverseLetter(string str)
        {
            return new string( str.Where(char.IsLetter).Reverse().Select(x => x).ToArray());
        }
=======================================================
return new String(str.Where(Char.IsLetter).Reverse().ToArray());
=======================================================
