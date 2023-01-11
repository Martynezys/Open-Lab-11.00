using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Library
    {
        int numberOfBooks;
        int numberOfStudents;
        List<string> studentsList = new List<string>();
        List<Book> booksList = new List<Book>();
        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        }
        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        public List<Book> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }
        public override string ToString()
        {
            string booksFromList = String.Empty;
            string studentsFromList = String.Empty;

            foreach (var x in studentsList)
            {
                studentsFromList += x + " ";
            }

            foreach (var x in booksList)
            {
                booksFromList += x + " ";
            }

            return String.Format($"Number of books: {this.numberOfBooks} Names: \n {booksFromList}\n Number of students: {this.numberOfStudents} \nNames: {studentsFromList} ");
        }
    }
}
