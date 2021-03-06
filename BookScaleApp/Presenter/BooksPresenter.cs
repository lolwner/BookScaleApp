﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookScaleApp.View;
using BookScaleApp.Model;

namespace BookScaleApp.Presenter
{
    public class BooksPresenter
    {
        private IBooksView view;

        public BooksPresenter(IBooksView view)
        {
            this.view = view;
        }

        public List<string> ShowBooks(string author_name)
        {
            var author = new Author { Name = author_name };
            List<string> BooksList = new List<string>();
            int id = 0;

            using (var db = new Context())
            {
                var author_id = from b in db.Authors where (b.Name == author.Name) select b.ID;
                if (author_id.Count() != 1)
                {
                    throw new Exception("Specify author, there is more than one");
                }
                    
                id = author_id.FirstOrDefault();
                var query = from b in db.Books where (b.Author_ID == id) select b;
                foreach (var i in query)
                {
                    BooksList.Add(i.Name);
                }
            }
            return BooksList;
        }

        public void DeleteBook()
        {
            using (var db = new Context())
            {
                var query = from b in db.Books where (b.Name == view.ChosenBook) select b;
                db.Books.Remove(query.FirstOrDefault());
                db.SaveChanges();
            }
        }

        public void UpdateBook(string authorName, string name)
        {
            using (var db = new Context())
            {
                var bookToUpdate = from book in db.Books where (book.Name == view.ChosenBook) select book;

                var author_id = from author in db.Authors where (author.Name == authorName) select author;
                bookToUpdate.FirstOrDefault().Author_ID = author_id.FirstOrDefault().ID;
                bookToUpdate.FirstOrDefault().Name = name;
                db.SaveChanges();
            }
        }

        public void CreateBook(string AuthorName, string Name)
        {
            using (var db = new Context())
            {
                var author_id = from author in db.Authors where (author.Name == AuthorName) select author;
                Book book = new Book();
                book.Author_ID = author_id.FirstOrDefault().ID;
                book.Name = Name;
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
    }
}
