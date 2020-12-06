using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Challenges
{
    //Chal_1 -- Create an abstract class **CHECK**
    //Chal_2 -- Give three properties & one virtual or **abstract method**
    abstract class Book
    {
        public string Title { get; set; }
        public string Author_First { get; set; }
        public string Author_Last { get; set; }
        public Book() { }
        public Book(string title, string author_First, string author_Last)
        {
            Title = title;
            Author_First = author_First;
            Author_Last = author_Last;
        }
    }

    //Chal_3 -- Declare at least two classes that will inherit from abstract class Book
    class FictionBook : Book
    {
        public bool IsBoringAsHell { get; set; }
        public FictionBook() { }
        public FictionBook(bool isBoringAsHell, string title, string author_First, string author_Last)
            : base(title, author_First, author_Last)
        {
            IsBoringAsHell = isBoringAsHell;
        }

        
    }

    class NonFictionBook : Book
    {
        public bool IsBiographical { get; set; }
    }
}
