using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookScaleApp.View;
using BookScaleApp.Model;

namespace BookScaleApp.Presenter
{


    public class AuthorsPresenter 
    {
        private IAuthorsView view;


        public AuthorsPresenter(IAuthorsView view)
        {
            this.view = view;
        }

        public List<string> ShowAuthorInfo()
        {
            List<string> AuthorInfo = new List<string>();

            using (var db = new Context())
            {
                var query = from b in db.Authors where (b.Name == view.ChosenAuthor) select b;
                foreach (var i in query)
                {
                    AuthorInfo.Add(i.Name);
                    AuthorInfo.Add(i.DateOfBirth.ToString());
                    if (i.DateOfDeath != null)
                    {
                        AuthorInfo.Add(i.DateOfDeath.ToString());
                    }
                }
                
            }
            return AuthorInfo;
        }

        public void DeleteAuthor()
        {
            using (var db = new Context())
            {
                var author = new Author { Name = view.ChosenAuthor };
                int id = 0;
                
                var author_id = from a in db.Authors where (a.Name == author.Name) select a;
                id = author_id.FirstOrDefault().ID;
                var booksID = from b in db.Books where (b.Author_ID == id) select b;

                foreach(var i in booksID)
                {
                    db.Books.Remove(i);
                }
                db.Authors.Remove(author_id.FirstOrDefault());

                db.SaveChanges();
            }
        }

        public void UpdateAuthor(string name, DateTime DoB, DateTime DoD)
        {
            using (var db = new Context())
            {
                var author = from a in db.Authors where (a.Name == view.ChosenAuthor) select a;
                author.FirstOrDefault().Name = name;
                author.FirstOrDefault().DateOfBirth = DoB;
                author.FirstOrDefault().DateOfDeath = DoD;

                db.SaveChanges();
            }
        }

        public void CreateAuthor(string name, DateTime DoB, DateTime DoD)
        {
            using (var db = new Context())
            {
                Author author = new Author();
                author.Name = name;
                author.DateOfBirth = DoB;
                author.DateOfDeath = DoD;

                db.Authors.Add(author);
                

                db.SaveChanges();
            }
        }

    }
    
}


