
Say hello!

Say hello!

Write a function to greet a person. Function will take name as input and greet the person by saying hello. Return null/nil if input is empty string or null/nil.

Example:

greet("Niks") == "hello Niks!"
greet("") == null; // Return null if input is empty string
greet(null) == null; // Return null if input is null

======================================================
Мое решение

        public static string greet(string name)
        {
            if (string.IsNullOrEmpty(name)) 
            {
                return null;
            }
            else
            {
                return string.Format("hello {0}!", name);
            }
          
        }
=====================================================
public class Greetings
{
  public static string greet(string name)
     => string.IsNullOrEmpty(name) ? null : $"hello {name}!";
}