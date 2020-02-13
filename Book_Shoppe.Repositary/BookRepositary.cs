using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Shoppe.Data;

namespace Book_Shoppe.Repositary
{
    public static class BookRepositary
    {
        public static List<Book> bookList = new List<Book>();

        static BookRepositary()
        {
            bookList.Add(new Book {BookID=1,Title= "Warrior",Author="Dany",Genere="Fiction",Price=200});
            bookList.Add(new Book { BookID = 2, Title = "It's Me", Author = "Willam", Genere = "Philasopy", Price = 240 });
            bookList.Add(new Book { BookID = 3, Title = "Please Don't", Author = "Robert", Genere = "Fiction", Price = 400 });
            bookList.Add(new Book { BookID = 4, Title = "Real Lover", Author = "John", Genere = "Story", Price = 730 });
        }
        public static IEnumerable<Book> GetAllBooks()
        {
            return bookList;
        }
    }
}
