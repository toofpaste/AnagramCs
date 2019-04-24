//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Anagram;
//using System;
//using System.Collections.Generic;

//namespace Anagram.Tests 
//{

//  [TestClass]
//  public class wordTest : IDisposable
//  {

//    public void Dispose()
//        {
//            word.ClearAll();
//        }
//    [TestMethod]
//        public void wordConstructor_CreatesInstanceOfword_word()
//        {
//            word newWord = new word("test");
//            Assert.AreEqual(typeof(word), newWord.GetType());
//        }

//        [TestMethod]
//        public void wordObject_CreateswordObject_Object()
//        {
//            word newWord = new word("test");
//            Assert.AreEqual("test", newWord.GetWord());
//        }
//           [TestMethod]
//        public void GetAll_ReturnsEmptyList_ItemList()
//        {
//            List<word> newList = new List<word> { };
//            List<word> result = word.GetAll();
//            CollectionAssert.AreEqual(newList, result);
//        }

//        [TestMethod]
//        public void GetAll_ReturnsItems_ItemList()
//        {
//            string description01 = "Walk";
//            string description02 = "Shit";
//            word newItem1 = new word(description01);
//            word newItem2 = new word(description02);
//            List<word> newList = new List<word> { newItem1, newItem2 };
//            List<word> result = word.GetAll();
//            CollectionAssert.AreEqual(newList, result);
//        }


//        [TestMethod]
//        public void CheckArray_ReturnsTrue_True()
//        {
//            string description01 = "walk";
//            string description02 = "klaw";
//            word newWord = new word(description01);

//            Assert.AreEqual(true, newWord.CheckArray(description02));
//        }

//        [TestMethod]
//        public void CheckArray_ReturnsTrue_False()
//        {
//            string description01 = "walk";
//            string description02 = "kkaw";
//            word newWord = new word(description01);

//            Assert.AreEqual(false, newWord.CheckArray(description02));
//        }
//  }
//}

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