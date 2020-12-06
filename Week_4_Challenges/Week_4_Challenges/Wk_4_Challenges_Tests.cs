using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_4_Challenges
{
    [TestClass]
    public class Wk_4_Challenges_Tests
    {
        [TestMethod]
        public void BookExamples()
        {

            //"...new up an instance of each class that inherits from the parent class you set up"
            //instance #1 -- FICTION
            var fictionBook = new FictionBook(true, "Empire of the Sun", "J.G.", "Ballard");
            fictionBook.Title = "";
            fictionBook.Author_First = "";
            fictionBook.Author_Last = "";
            fictionBook.IsBoringAsHell = true;

            //instance #2 -- NONFICTION
            var nonFictionBook = new NonFictionBook();
            nonFictionBook.Title = "All Quiet on the Western Front";
            nonFictionBook.Author_First = "Erich";
            nonFictionBook.Author_Last = "Remarque";
            nonFictionBook.IsBiographical = true;


        }
    }
}
