using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set
            {

                if (pages < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        private string category;
        public string Category
        {

            set { category = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (releaseDate < 1450 && releaseDate > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }

        public Book()
        {
            this.title = "-1";
            this.pages = -1;
            this.category = "-1";
            this.author = "-1";
            this.releaseDate = -1;
        }

        public Book(string xTitle, int xPages)
        {
            this.title = xTitle;
            this.pages = xPages;

            this.category = "-1";
            this.author = "-1";
            this.releaseDate = -1;
        }

        public Book(string xTitle, int XPages, string xCategory, string xAuthor, int xReleaseDate)
        {
            this.title = xTitle;
            this.pages = XPages;
            this.category = xCategory;
            this.author = xAuthor;
            this.releaseDate = xReleaseDate;
        }
        

        /// <summary>
        ///  Nad tento list (a všetky vlastnosti) použite trojlomítkový zápis komentára, ktorý popisuje daný dátový objekt.
        /// </summary>
        public static readonly List<string> categoryList = new List<string>() { "detské", "romanticke", "naucne", "sci-fi", "dobrodruzne" };


        public override string ToString()
        {
            return string.Format($"\n{title}\n{pages}\n{category}\n{author}\n{releaseDate}\n");
        }


    }
}