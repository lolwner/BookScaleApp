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
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.bookScaleAppModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BookScaleApp_Model_ContextDataSet = new BookScaleApp._BookScaleApp_Model_ContextDataSet();
            this.bookScaleAppModelContextDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(236, 10);
            this.BookNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.BookNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author is";
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.Location = new System.Drawing.Point(236, 44);
            this.AuthorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.AuthorNameTextBox.TabIndex = 3;
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
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(9, 10);
            this.BooksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(151, 173);
            this.BooksListBox.TabIndex = 5;
            this.BooksListBox.Click += new System.EventHandler(this.BooksListBox_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(165, 138);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(165, 82);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(165, 109);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 300);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.AuthorNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private _BookScaleApp_Model_ContextDataSet _BookScaleApp_Model_ContextDataSet;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource2;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource1;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
    }
}