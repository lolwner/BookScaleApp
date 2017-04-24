using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookScaleApp.Presenter;
// Rename handlers
namespace BookScaleApp.View
{
    public partial class BookForm : Form, IBooksView
    {
        private string chosenAuthor;
        private List<string> books;

        private BooksPresenter presenter;

        public string ChosenBook
        {
            get { return BooksListBox.GetItemText(BooksListBox.SelectedItem); }
        }

        public BookForm(string chosenAuthor)
        {
            presenter = new BooksPresenter(this);
            InitializeComponent();
            this.chosenAuthor = chosenAuthor;

            ShowInfo();
            foreach (var i in books)
            {
                BooksListBox.Items.Add(i);
            }
        }

        public void ShowInfo()
        {
            books = presenter.ShowBooks(chosenAuthor);
        }

        private void BooksListBox_Click(object sender, EventArgs e)
        {
            BookNameTextBox.Text = ChosenBook;
            AuthorNameTextBox.Text = chosenAuthor;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            presenter.UpdateBook(AuthorNameTextBox.Text, BookNameTextBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            presenter.CreateBook(AuthorNameTextBox.Text, BookNameTextBox.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteBook();
            BooksListBox.Items.Remove(books.Find(x => x == ChosenBook));
        }
    }
}
