namespace BookScaleApp.View
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bookScaleAppModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BookScaleApp_Model_ContextDataSet = new BookScaleApp._BookScaleApp_Model_ContextDataSet();
            this.bookScaleAppModelContextDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author is";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 226);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // bookScaleAppModelContextDataSetBindingSource
            // 
            this.bookScaleAppModelContextDataSetBindingSource.DataSource = this._BookScaleApp_Model_ContextDataSet;
            this.bookScaleAppModelContextDataSetBindingSource.Position = 0;
            // 
            // _BookScaleApp_Model_ContextDataSet
            // 
            this._BookScaleApp_Model_ContextDataSet.DataSetName = "_BookScaleApp_Model_ContextDataSet";
            this._BookScaleApp_Model_ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookScaleAppModelContextDataSetBindingSource1
            // 
            this.bookScaleAppModelContextDataSetBindingSource1.DataSource = this._BookScaleApp_Model_ContextDataSet;
            this.bookScaleAppModelContextDataSetBindingSource1.Position = 0;
            // 
            // bookScaleAppModelContextDataSetBindingSource2
            // 
            this.bookScaleAppModelContextDataSetBindingSource2.DataSource = this._BookScaleApp_Model_ContextDataSet;
            this.bookScaleAppModelContextDataSetBindingSource2.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 173);
            this.listBox1.TabIndex = 5;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 300);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private _BookScaleApp_Model_ContextDataSet _BookScaleApp_Model_ContextDataSet;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource2;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource1;
        private System.Windows.Forms.ListBox listBox1;
    }
}