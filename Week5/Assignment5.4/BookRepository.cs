using System;
using System.Collections.Generic;
using System.Drawing;

namespace BookRepositoryDLL
{
    public class Book
    {
        public Image bitmap { get; set; }
        public string ISBN10 { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string AmazonUrl { get; set; }
        public string imageUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public float Price { get; set; }
    }
    public class BookRepository
    {
        private List<Book> bookslist;

        public BookRepository()
        {
            bookslist = new List<Book>() {
                new Book(){
                    ISBN10="1524713317",
                    BookName="Owls Are Good at Keeping Secrets: An Unusual Alphabet",
                    Author="Sara O'Leary, Jacob Grant",
                    AmazonUrl="Owls-are-Good-Keeping-Secrets/dp/1524713317",
                    imageUrl="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1516645637l/38123950._SX318_.jpg",
                    PublishedDate=new DateTime(2018,12,4),
                    Price=17.99f},

                new Book(){
                    ISBN10="0143035002",
                    BookName="Anna Karenina",
                    Author="Leo Tolstoy",
                    AmazonUrl="Anna-Karenina-Leo-Tolstoy/dp/0143035002",
                    imageUrl="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1601352433l/15823480._SY475_.jpg",
                    PublishedDate=new DateTime(2004,5,1),
                    Price=14.53f},

                new Book(){
                    ISBN10="0679753796",
                    BookName="Dance Dance Dance",
                    Author="Haruki Murakami",
                    AmazonUrl="Dance-Haruki-Murakami/dp/06797537962",
                    imageUrl="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1514582521l/17800._SY475_.jpg",
                    PublishedDate=new DateTime(1995,1,31),
                    Price=11.52f},

                new Book(){
                    ISBN10="014243714X",
                    BookName="The Tale of Genji",
                    Author="Murasaki Shikibu",
                    AmazonUrl="Tale-Genji-Penguin-Classics-Deluxe/dp/014243714X2",
                    imageUrl="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1616514777l/7042._SX318_.jpg",
                    PublishedDate=new DateTime(2002,11,26),
                    Price=23.49f},

                new Book(){
                    ISBN10="0307742539",
                    BookName="The Girl Who Kicked the Hornet's Nest",
                    Author="Stieg Larsson",
                    AmazonUrl="Girl-Kicked-Hornets-Nest-Millennium/dp/0307742539",
                    imageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327708260l/6892870.jpg",
                    PublishedDate=new DateTime(2012,2,21),
                    Price=7.99f},

                new Book(){
                    ISBN10="0345487133",
                    BookName="Earth Abides",
                    Author="George R. Stewart",
                    AmazonUrl="Earth-Abides-George-R-Stewart/dp/0345487133",
                    imageUrl="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1320505234l/93269.jpg",
                    PublishedDate=new DateTime(2006,3,28),
                    Price=18.09f}
            };
        }

        public List<Book> GetBooksList()
        {
            return bookslist;
        }

        public void AddBook(string ISBN, string bookname, string author, string aUrl, string iUrl, DateTime dt, float price)
        {
            Book newbook = new Book();
            newbook.ISBN10 = ISBN;
            newbook.BookName = bookname;
            newbook.Author = author;
            newbook.AmazonUrl = aUrl;
            newbook.imageUrl = iUrl;
            newbook.PublishedDate = dt;
            newbook.Price = price;

            bookslist.Add(newbook);
        }

        public void AddBook(Book newbook)
        {
            bookslist.Add(newbook);
        }

        public void DeleteBook(int id)
        {
            bookslist.RemoveAt(id);
        }

    }
}
