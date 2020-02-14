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
            bookList.Add(new Book { BookID = 1, Title = "Warrior", Author = "Dany", Genere = "Fiction", Price = 200 });
            bookList.Add(new Book { BookID = 2, Title = "It's Me", Author = "Willam", Genere = "Philasopy", Price = 240 });
            bookList.Add(new Book { BookID = 3, Title = "Please Don't", Author = "Robert", Genere = "Fiction", Price = 400 });
            bookList.Add(new Book { BookID = 4, Title = "Real Lover", Author = "John", Genere = "Story", Price = 730 });
        }
        public static void Add(Book book)
        {
            bookList.Add(book);
        }
        public static void Delete(int BookID)
        {
            Book book = GetBookByID(BookID);
            if (book != null)
                bookList.Remove(book);
        }
        public static void Updata(Book book)
        {
            Book bookValue = bookList.Find(id => id.BookID == book.BookID);
            bookValue.Title = book.Title;
            bookValue.Author = book.Author;
            bookValue.Genere = book.Genere;
            bookValue.NoOfPages = book.NoOfPages;
            bookValue.Price = book.Price;
        }
        public static IEnumerable<Book> GetAllBooks()
        {
            return bookList;
        }
        public static Book GetBookByID(int bookID)
        {
            return bookList.Find(id => id.BookID == bookID);
        }
    }
}
