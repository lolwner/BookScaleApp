namespace BookScaleApp
{
    partial class AuthorsForm
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
            this.ShowAuthorInfoButton = new System.Windows.Forms.Button();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BookScaleApp_Model_ContextDataSet = new BookScaleApp._BookScaleApp_Model_ContextDataSet();
            this.AuthorsDataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new BookScaleApp._BookScaleApp_Model_ContextDataSetTableAdapters.AuthorsTableAdapter();
            this.authorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ShowBooksButton = new System.Windows.Forms.Button();
            this.DeleteAuthorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDoD = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAuthorInfoButton
            // 
            this.ShowAuthorInfoButton.Location = new System.Drawing.Point(10, 167);
            this.ShowAuthorInfoButton.Name = "ShowAuthorInfoButton";
            this.ShowAuthorInfoButton.Size = new System.Drawing.Size(168, 23);
            this.ShowAuthorInfoButton.TabIndex = 0;
            this.ShowAuthorInfoButton.Text = "Show author info";
            this.ShowAuthorInfoButton.UseVisualStyleBackColor = true;
            this.ShowAuthorInfoButton.Click += new System.EventHandler(this.ShowAuthorButton_Click);
            // 
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataMember = "Authors";
            this.authorsBindingSource1.DataSource = this.bookScaleAppModelContextDataSetBindingSource;
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
            // AuthorsDataGrid
            // 
            this.AuthorsDataGrid.AllowUserToAddRows = false;
            this.AuthorsDataGrid.AllowUserToDeleteRows = false;
            this.AuthorsDataGrid.AutoGenerateColumns = false;
            this.AuthorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.AuthorsDataGrid.DataSource = this.authorsBindingSource5;
            this.AuthorsDataGrid.Location = new System.Drawing.Point(10, 11);
            this.AuthorsDataGrid.Name = "AuthorsDataGrid";
            this.AuthorsDataGrid.ReadOnly = true;
            this.AuthorsDataGrid.Size = new System.Drawing.Size(168, 150);
            this.AuthorsDataGrid.TabIndex = 1;
            this.AuthorsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsDataGrid_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsBindingSource5
            // 
            this.authorsBindingSource5.DataMember = "Authors";
            this.authorsBindingSource5.DataSource = this._BookScaleApp_Model_ContextDataSet;
            // 
            // authorsBindingSource3
            // 
            this.authorsBindingSource3.DataMember = "Authors";
            this.authorsBindingSource3.DataSource = this.bookScaleAppModelContextDataSetBindingSource1;
            // 
            // bookScaleAppModelContextDataSetBindingSource1
            // 
            this.bookScaleAppModelContextDataSetBindingSource1.DataSource = this._BookScaleApp_Model_ContextDataSet;
            this.bookScaleAppModelContextDataSetBindingSource1.Position = 0;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this._BookScaleApp_Model_ContextDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingSource2
            // 
            this.authorsBindingSource2.DataMember = "Authors";
            this.authorsBindingSource2.DataSource = this._BookScaleApp_Model_ContextDataSet;
            // 
            // authorsBindingSource4
            // 
            this.authorsBindingSource4.DataMember = "Authors";
            this.authorsBindingSource4.DataSource = this._BookScaleApp_Model_ContextDataSet;
            // 
            // ShowBooksButton
            // 
            this.ShowBooksButton.Location = new System.Drawing.Point(10, 195);
            this.ShowBooksButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowBooksButton.Name = "ShowBooksButton";
            this.ShowBooksButton.Size = new System.Drawing.Size(168, 24);
            this.ShowBooksButton.TabIndex = 2;
            this.ShowBooksButton.Text = "Show books";
            this.ShowBooksButton.UseVisualStyleBackColor = true;
            this.ShowBooksButton.Click += new System.EventHandler(this.ShowBooksButton_Click);
            // 
            // DeleteAuthorButton
            // 
            this.DeleteAuthorButton.Location = new System.Drawing.Point(10, 224);
            this.DeleteAuthorButton.Name = "DeleteAuthorButton";
            this.DeleteAuthorButton.Size = new System.Drawing.Size(168, 23);
            this.DeleteAuthorButton.TabIndex = 4;
            this.DeleteAuthorButton.Text = "Delete author";
            this.DeleteAuthorButton.UseVisualStyleBackColor = true;
            this.DeleteAuthorButton.Click += new System.EventHandler(this.DeleteAuthorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edit author info";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(190, 124);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(258, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of death";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.Location = new System.Drawing.Point(258, 69);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDoB.TabIndex = 13;
            // 
            // dateTimePickerDoD
            // 
            this.dateTimePickerDoD.Location = new System.Drawing.Point(258, 98);
            this.dateTimePickerDoD.Name = "dateTimePickerDoD";
            this.dateTimePickerDoD.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDoD.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(307, 124);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 299);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dateTimePickerDoD);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteAuthorButton);
            this.Controls.Add(this.ShowBooksButton);
            this.Controls.Add(this.AuthorsDataGrid);
            this.Controls.Add(this.ShowAuthorInfoButton);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowAuthorInfoButton;
        private _BookScaleApp_Model_ContextDataSet _BookScaleApp_Model_ContextDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private _BookScaleApp_Model_ContextDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private System.Windows.Forms.BindingSource authorsBindingSource2;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource1;
        private System.Windows.Forms.DataGridView AuthorsDataGrid;
        private System.Windows.Forms.BindingSource authorsBindingSource3;
        private System.Windows.Forms.BindingSource authorsBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorsBindingSource5;
        private System.Windows.Forms.Button ShowBooksButton;
        private System.Windows.Forms.Button DeleteAuthorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoD;
        private System.Windows.Forms.Button AddButton;
    }
}

