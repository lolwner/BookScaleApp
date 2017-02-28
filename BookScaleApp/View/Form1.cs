using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookScaleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BookScaleApp.Model.Context())
            {
                var author = new BookScaleApp.Model.Author { Name = "test" };
                db.Authors.Add(author);
                db.SaveChanges();
                var query = from b in db.Authors orderby b.Name select b;
                foreach(var i in query)
                {
                    MessageBox.Show(i.Name);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BookScaleApp_Model_ContextDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this._BookScaleApp_Model_ContextDataSet.Authors);

        }
    }
}
