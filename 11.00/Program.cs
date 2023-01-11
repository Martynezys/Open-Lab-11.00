
using Open_Lab_11._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Library schoolLibrary = new Library();

            Book matematikaVKocke = new Book("Matematika v Kocke", 69);
            Book zakladyElektrotechniky = new Book("Zaklady Elektrotechniky", 420);
            Book hravaslovencina = new Book("Hrava Slovencina", 158);
            Book pripravanamaturitu = new Book("Priprava na Maturitu pre Blbcov", 675);


            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add(matematikaVKocke);
            schoolLibrary.BooksList.Add(zakladyElektrotechniky);
            schoolLibrary.BooksList.Add(hravaslovencina);
            schoolLibrary.BooksList.Add(pripravanamaturitu);
            schoolLibrary.NumberOfStudents = 2;
            schoolLibrary.NumberOfBooks = 4;


            
          

            Console.WriteLine(schoolLibrary.ToString());
            Console.ReadLine();
        }
    }
}
