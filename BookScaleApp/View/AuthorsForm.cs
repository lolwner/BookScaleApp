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
            get { return dataGridView1.CurrentRow.Cells[0].Value.ToString(); }
        }



        public void ShowInfo()
        {
            List<string> info = presenter.ShowAuthorInfo();
            foreach(var i in info)
            {
                MessageBox.Show(i);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BookScaleApp_Model_ContextDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form = new BookForm(ChosenAuthor);
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.DeleteAuthor();
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            presenter.UpdateAuthor(textBoxName.Text, dateTimePickerDoB.Value, dateTimePickerDoD.Value);
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = ChosenAuthor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.CreateAuthor(textBoxName.Text, dateTimePickerDoB.Value, dateTimePickerDoD.Value);
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);
        }
    }
}
