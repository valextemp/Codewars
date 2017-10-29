TASKS

Kata
You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that 
should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. 
It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
For more than 4 names, the number in and 2 others simply increases.
============================================================================

public static class Kata
{
  public static string Likes(string[] names)
  {
    switch (names.Length)
    {
      case 0: return "no one likes this"; // :(
      case 1: return $"{names[0]} likes this";
      case 2: return $"{names[0]} and {names[1]} like this";
      case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
      default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
    }
  }
}