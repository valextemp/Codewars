In this kata you get the start number and the end number of a region and should return the count of all numbers except numbers with a 5 in it.
The start and the end number are both inclusive!

Examples:

1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
The result may contain fives. ;-)
The start number will always be smaller than the end number. Both numbers can be also negative!

I'm very curious for your solutions and the way you solve it. Maybe someone of you will find an easy pure mathematics solution.

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have also created other katas. Take a look if you enjoyed this kata!

==============================================================
//моя реализация
        public static int DontGiveMeFive(int start, int end)
        {
            int number = 0;
            if (start < end)
            {
                for (int x = start; x <= end; x++)
                {
                    if (x.ToString().IndexOf('5') == -1) number++;
                }
            }
            return number;
        }


// Некоторые реализации
  public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start, end-start+1).Count(x => !x.ToString().Contains("5"));
  }
//самое хорошое написано

//тоже через Lnq но более понятное
  public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start,end-start+1)
                     .Where(x => !x.ToString().Contains("5"))
                     .Count();
  }

//тоже через Lnq но более понятное
    public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start, end-start+1).Select(e => e.ToString()).ToList().Where(x =>!x.Contains("5")).Count();
  }

//тоже через Lnq 
  public class Kata
{
  public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start, end-start+1).ToArray().Count(x => !x.ToString().Contains('5'));    
  }
}

//тоже через Lnq 
  public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start, end-start+1).Select(e => e.ToString()).ToList().Where(x =>!x.Contains("5")).Count();
  }


  //тоже интересное решение через регулярные выражения
    public static int DontGiveMeFive(int start, int end)
  {
    string Pattern = "[5]";
            Regex r = new Regex(Pattern);
            List<int> List = new List<int>();

            for (var i = start; i <= end; i++)
            {
                if (r.IsMatch(i.ToString()))
                {
                    continue;        
                }
                List.Add(i);
            }
            Console.WriteLine("[{0}]", string.Join(", ", List));
            Console.WriteLine(List.Count);
            return List.Count;
  }

