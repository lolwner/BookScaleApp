using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookScaleApp.View;
using BookScaleApp.Presenter;

namespace BookScaleApp
{
    public partial class AuthorsForm : Form, IAuthorsView
    {
        private AuthorsPresenter presenter;

        public AuthorsForm()
        {
            presenter = new AuthorsPresenter(this);
            InitializeComponent();
        }

        public string ChosenAuthor
        {
            get { return AuthorsDataGrid.CurrentRow.Cells[0].Value.ToString(); }
        }

        public void ShowInfo()
        {
            List<string> info = presenter.ShowAuthorInfo();
            foreach(var i in info)
            {
                MessageBox.Show(i);
            }
        }

        private void ShowAuthorButton_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowBooksButton_Click(object sender, EventArgs e)
        {
            var Form = new BookForm(ChosenAuthor);
            Form.Show();
        }

        private void DeleteAuthorButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteAuthor();
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            presenter.UpdateAuthor(textBoxName.Text, dateTimePickerDoB.Value, dateTimePickerDoD.Value);
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            presenter.CreateAuthor(textBoxName.Text, dateTimePickerDoB.Value, dateTimePickerDoD.Value);
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }

        private void AuthorsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = ChosenAuthor;
        }
    }
}
