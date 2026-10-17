namespace BANKOMAT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankomatDataSet1 = new BANKOMAT.BankomatDataSet1();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankomatDataSet = new BANKOMAT.BankomatDataSet();
            this.t1TableAdapter = new BANKOMAT.BankomatDataSetTableAdapters.t1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.t1TableAdapter1 = new BANKOMAT.BankomatDataSet1TableAdapters.t1TableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.bankomatDataSet2 = new BANKOMAT.BankomatDataSet2();
            this.sDatoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_datoyTableAdapter = new BANKOMAT.BankomatDataSet2TableAdapters.S_datoyTableAdapter();
            this.tovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankomatDataSet3 = new BANKOMAT.BankomatDataSet3();
            this.dataaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataaTableAdapter = new BANKOMAT.BankomatDataSet3TableAdapters.DataaTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDatoyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kupyura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(511, 2);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 228);
            this.listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tovarDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "Tovar";
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "Kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "Kol";
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            // 
            // t1BindingSource1
            // 
            this.t1BindingSource1.DataMember = "t1";
            this.t1BindingSource1.DataSource = this.bankomatDataSet1;
            // 
            // bankomatDataSet1
            // 
            this.bankomatDataSet1.DataSetName = "BankomatDataSet1";
            this.bankomatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "t1";
            this.t1BindingSource.DataSource = this.bankomatDataSet;
            // 
            // bankomatDataSet
            // 
            this.bankomatDataSet.DataSetName = "BankomatDataSet";
            this.bankomatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vicisleniye";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t1TableAdapter1
            // 
            this.t1TableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 141);
            this.button3.TabIndex = 6;
            this.button3.Text = "save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tovar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kol";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tovarDataGridViewTextBoxColumn1,
            this.tarixDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn1,
            this.kolDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.dataaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(27, 561);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(676, 150);
            this.dataGridView2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 450);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 39);
            this.button4.TabIndex = 15;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bankomatDataSet2
            // 
            this.bankomatDataSet2.DataSetName = "BankomatDataSet2";
            this.bankomatDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sDatoyBindingSource
            // 
            this.sDatoyBindingSource.DataMember = "S datoy";
            this.sDatoyBindingSource.DataSource = this.bankomatDataSet2;
            // 
            // s_datoyTableAdapter
            // 
            this.s_datoyTableAdapter.ClearBeforeFill = true;
            // 
            // tovarDataGridViewTextBoxColumn1
            // 
            this.tovarDataGridViewTextBoxColumn1.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn1.HeaderText = "Tovar";
            this.tovarDataGridViewTextBoxColumn1.Name = "tovarDataGridViewTextBoxColumn1";
            // 
            // tarixDataGridViewTextBoxColumn
            // 
            this.tarixDataGridViewTextBoxColumn.DataPropertyName = "Tarix";
            this.tarixDataGridViewTextBoxColumn.HeaderText = "Tarix";
            this.tarixDataGridViewTextBoxColumn.Name = "tarixDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn1
            // 
            this.cenaDataGridViewTextBoxColumn1.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn1.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn1.Name = "cenaDataGridViewTextBoxColumn1";
            // 
            // kolDataGridViewTextBoxColumn1
            // 
            this.kolDataGridViewTextBoxColumn1.DataPropertyName = "Kol";
            this.kolDataGridViewTextBoxColumn1.HeaderText = "Kol";
            this.kolDataGridViewTextBoxColumn1.Name = "kolDataGridViewTextBoxColumn1";
            // 
            // bankomatDataSet3
            // 
            this.bankomatDataSet3.DataSetName = "BankomatDataSet3";
            this.bankomatDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataaBindingSource
            // 
            this.dataaBindingSource.DataMember = "Dataa";
            this.dataaBindingSource.DataSource = this.bankomatDataSet3;
            // 
            // dataaTableAdapter
            // 
            this.dataaTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 500);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 37);
            this.button5.TabIndex = 17;
            this.button5.Text = "Vicisleniye";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 36);
            this.button6.TabIndex = 18;
            this.button6.Text = "Sort";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 723);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDatoyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankomatDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankomatDataSet bankomatDataSet;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private BankomatDataSetTableAdapters.t1TableAdapter t1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private BankomatDataSet1 bankomatDataSet1;
        private System.Windows.Forms.BindingSource t1BindingSource1;
        private BankomatDataSet1TableAdapters.t1TableAdapter t1TableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private BankomatDataSet2 bankomatDataSet2;
        private System.Windows.Forms.BindingSource sDatoyBindingSource;
        private BankomatDataSet2TableAdapters.S_datoyTableAdapter s_datoyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn1;
        private BankomatDataSet3 bankomatDataSet3;
        private System.Windows.Forms.BindingSource dataaBindingSource;
        private BankomatDataSet3TableAdapters.DataaTableAdapter dataaTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

