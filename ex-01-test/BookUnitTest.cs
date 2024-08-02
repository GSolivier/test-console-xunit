using ex_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01_test
{
    public class BookUnitTest
    {
        [Fact]
        public void TestAddBook() 
        {
            var newBook = "Harry Potter";

            var expectedValue = "Harry Potter";
            

            var books = BookManagement.AddBook(newBook);

            Assert.Equal(books[0], expectedValue);
        }

    }
}
