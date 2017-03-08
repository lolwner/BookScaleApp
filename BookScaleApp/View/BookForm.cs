﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookScaleApp.Presenter;

namespace BookScaleApp.View
{
    public partial class BookForm : Form, IBooksView
    {
        string ChosenAuthor;
        List<string> books;

        private BooksPresenter presenter;

        public string ChosenBook
        {
            get { return listBox1.GetItemText(listBox1.SelectedItem); }
        }

        public BookForm(string CA)
        {
            presenter = new BooksPresenter(this);
            InitializeComponent();
            ChosenAuthor = CA;

            ShowInfo();
            foreach (var i in books)
            {
                listBox1.Items.Add(i);
            }
        }

        public void ShowInfo()
        {
            books = presenter.ShowBooks(ChosenAuthor);
        }       

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ChosenBook;
            textBox2.Text = ChosenAuthor;
        }
    }
}