using System;
using System.Collections.Generic;

namespace Anagram
{
  public class word
  {
       private string _firstWord;
        private static List<word> _instances = new List<word> { };
        public word(string firstWord)
        {
            _firstWord = firstWord;
            _instances.Add(this);
        }
        public string GetWord()
        {
            return _firstWord;
        }
         public static List<word> GetAll()
        {
            return _instances;
        }
        public bool CheckArray(string firstWord, string word2)
        {
            char[] firstChar = firstWord.ToCharArray();
            char[] secondChar = word2.ToCharArray();
            //Console.WriteLine("First array: " + firstChar);
            //Console.WriteLine("2nd array: " + secondChar);
            Array.Sort(firstChar);
            Array.Sort(secondChar);
            if (firstWord.Length == word2.Length)
            {
                //Console.WriteLine("First array sort: " + firstChar);
                //Console.WriteLine("2nd array sort: " + secondChar);
                string firstString = new string(firstChar);
                string secondString = new string(secondChar);
                //Console.WriteLine("First String: " + firstString);
                //Console.WriteLine("2nd String: " + secondString);
                if (firstString == secondString)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                int i = 0;
                int x = 0;
                int charMatch = 0;
                while(i < secondChar.Length)
                {
                    while(x < firstChar.Length && i < secondChar.Length)
                    {
                        if (secondChar[i] == firstChar[x])
                        {
                            firstChar[x] = '0';
                            charMatch++;
                            i++;
                            x = 0;
                        }
                        x++;
                    }

                    i++;
                }
                if (charMatch == word2.Length)
                {
                    return true;
                }
                else return false;
            }
                
        }



              public static void ClearAll()
        {
            _instances.Clear();
        }
}
}
//word1 = shiit
//word2 = hti

//if(word1.length == word2.length)
//        true = original check array idea


//        false new method


//        split into char array both.
//      sort by alpha

//in a loop that runs word2Array.length int i
//              nested loop for word1Array.length int x
//                  if(word2Array[i] == word1Array[x])
//                    charMatch++;
//                       i++
                       
//    end loop


//    if(charMatch == word2.length)
//        is contained


//h - s f
//h - h t i++


//i - s f
//i - i t i++

// add user input to list .ToLower();

 //kayak <- user inputted word .ToLower()
 //Array.ToCharArray();
 //k, a, y, a, k
 //Array.Sort(ArrayName);
 //a, a, k, k, y

 //aaykk, dog, eidedj <- user inputted list .ToLower()
 //List<word> listHold = word.GetAll();

 //foreach word thisWord in listHold
 //on first loop
     //thisWord.ToCharArray();
     //a, a, y, k, k
     //Array.Sort(ArrayName2)
     //a, a, k, k, y
     //ArrayName.Join("")
     //ArrayName2.Join("")
     //CheckArray(string, string) return true
    
// -----
// on second loop
//     thisWord.ToCharArray();
//     d, o, g,
//     Array.Sort(ArrayName2)
//     d, g, o
//     ArrayName.Join("")
//     ArrayName2.Join("")
//     CheckArray(string, string) return false
// ------
// print correct result







