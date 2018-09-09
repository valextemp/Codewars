
Find the capitals

Instructions
Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters 
in the string.

Example
Assert.AreEqual(Kata.Capitals("CodEWaRs"), new int[]{0,3,4,6});
===================================================
Мое решение
return  word.Select((wr, ind) => char.IsUpper(wr)?ind:-1).Where(w => w>=0).ToArray<int>();

забавно есть такое же и оно одно из clever
===================================================
  public static int[] Capitals(string word)
  {
     var capitalIndexes = new List<int>();

      for (var i = 0; i < word.Length; i++)
      {
        if (char.IsUpper(word[i]))
          capitalIndexes.Add(i);
      }

      return capitalIndexes.ToArray();
  }
------------------------------------------------------
  public static int[] Capitals(string word)
  {
    return word.ToCharArray()
      .Select( (c, index) =>  new { CharAtIndex = c, Idx = index} )  // Select word and project to array "char with Index"
      .Where(indexedList => Char.IsUpper(indexedList.CharAtIndex))   // Filter where char is upp
      .Select(selected => selected.Idx) // return what is required: list of indices
      .ToArray();
  }
------------------------------------------------------
  public static int[] Capitals(string word)
  {
     var letters = word.ToCharArray();
     return letters.Select((x, i) => new { x, i })
                   .Where(y => char.IsUpper(y.x))
                   .Select(z => z.i)
                   .ToArray();
  }
------------------------------------------------------