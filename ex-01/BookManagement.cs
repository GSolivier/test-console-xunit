using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01
{
    public static class BookManagement
    {
        public static List<string> AddBook(String newBook)
        {
            var books = new List<string>();

            books.Add(newBook);

            return books;
        }
    }
}
