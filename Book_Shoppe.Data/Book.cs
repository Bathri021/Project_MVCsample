﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shoppe.Data
{
    public class Book
    {
        public int BookID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genere { get; set; }
        public int Price { get; set; }
        public int NoOfPages { get; set; }
        public int Discount { get; set; }

        //public Book(int userID, string title, string author, string genere, int price, int noOfPages)
        //{
        //    this.UserID = userID;
        //    this.Title = title;
        //    this.Author = author;
        //    this.Genere = genere;
        //    this.Price = price;
        //    this.NoOfPages = noOfPages;
        //}
        //public Book(int userID, string title, string author, string genere, int price, int noOfPages, int bookID)
        //{
        //    this.UserID = userID;
        //    this.Title = title;
        //    this.Author = author;
        //    this.Genere = genere;
        //    this.Price = price;
        //    this.NoOfPages = noOfPages;
        //    this.BookID = bookID;
        //}

    }
}
