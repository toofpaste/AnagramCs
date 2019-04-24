using System;
using System.Collections.Generic;

namespace Anagram
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Anagram Finder");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter the word you want checked");
            string firstWord = Console.ReadLine();

            int i = 0;
            while(i == 0)
            {
                Console.WriteLine("Would you like to add a word to the list or check? [Add/Check]");
                bool check = Console.ReadLine().ToLower() == "add";

                if(check)
                {
                    Console.WriteLine("Add a word");
                    string wordHold = Console.ReadLine();
                    new word(wordHold);
                
                }
                else
                {
                    List<word> listHold = word.GetAll();
                    foreach(word thisWord in listHold)
                    {
                        if(thisWord.CheckArray(firstWord, thisWord.GetWord()))
                        {
                            Console.WriteLine(thisWord.GetWord() + " is an anagram of " + firstWord);
                        }
                        else
                        {
                            Console.WriteLine(thisWord.GetWord() + " is not an anagram of " + firstWord);
                        }
                    }
                    i = 1;
                    break;

                }
            }
        }
    }
}


// add user input to list .ToLower();

// kayak <- user inputted word .ToLower()
// Array.ToCharArray();
// k, a, y, a, k
// Array.Sort(ArrayName);
// a, a, k, k, y

// aaykk, dog, eidedj <- user inputted list .ToLower()
// List<word> listHold = word.GetAll();

// foreach word thisWord in listHold
// on first loop
//     thisWord.ToCharArray();
//     a, a, y, k, k
//     Array.Sort(ArrayName2)
//     a, a, k, k, y
//     ArrayName.Join("")
//     ArrayName2.Join("")
//     CheckArray(string, string) return true
    
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