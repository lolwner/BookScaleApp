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
            this.button1 = new System.Windows.Forms.Button();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BookScaleApp_Model_ContextDataSet = new BookScaleApp._BookScaleApp_Model_ContextDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookScaleAppModelContextDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new BookScaleApp._BookScaleApp_Model_ContextDataSetTableAdapters.AuthorsTableAdapter();
            this.authorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDoD = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show author info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(168, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete author";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 299);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePickerDoD);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookScaleAppModelContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BookScaleApp_Model_ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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

        private System.Windows.Forms.Button button1;
        private _BookScaleApp_Model_ContextDataSet _BookScaleApp_Model_ContextDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private _BookScaleApp_Model_ContextDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private System.Windows.Forms.BindingSource authorsBindingSource2;
        private System.Windows.Forms.BindingSource bookScaleAppModelContextDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource authorsBindingSource3;
        private System.Windows.Forms.BindingSource authorsBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorsBindingSource5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoD;
        private System.Windows.Forms.Button button5;
    }
}

