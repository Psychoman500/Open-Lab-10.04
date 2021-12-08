using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._04
{
    public class Book
    {
        public int pages;
        public string title;
        public string category;
        public string author;
        public int releaseDate;

        public Book()
        {
            pages = -1;
            title = "-1";
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(int pages, string title)
        {
            this.pages = pages;
            this.title = title;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(int pages, string title, string category, string author, int releaseDate)
        {
            this.pages = pages;
            this.title = title;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }
        public void GetTitle(string SetTitle)
        {
            title = SetTitle;
            Console.WriteLine(title);
        }
        public void GetPages(int SetPages)
        {
            if (SetPages < 0)
            {
                SetPages = 1;
            }
            pages = SetPages;
            Console.WriteLine(pages);
        }
        public void GetCathegory(string SetCategory)
        {
            category = SetCategory;
            Console.WriteLine(category);
        }
        public void GetAuthor(string SetAuthor)
        {
            author = SetAuthor;
            Console.WriteLine(author);
        }
        public void GetReleaseDate(int SetRealeaseDate)
        {
            if (SetRealeaseDate < 1450)
            {
                SetRealeaseDate = -1;
            }
            else if (SetRealeaseDate > 2021)
            {
                SetRealeaseDate = -1;
            }
            releaseDate = SetRealeaseDate;
            Console.WriteLine(releaseDate);
        }
        public void WriteAllVariables()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book();
            Book LOTR3 = new Book(85, "Madam");
            Book HOBIT = new Book(85, "Madam", "Fantasy", "Hanna Suchá", 2019);
            LOTR.GetTitle("Madam");
            LOTR.GetPages(85);
            LOTR.GetCathegory("Fantasy");
            LOTR.GetAuthor("Hanna Suchá");
            LOTR.GetReleaseDate(2019);

            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(HOBIT.ToString());
        }

    }
}