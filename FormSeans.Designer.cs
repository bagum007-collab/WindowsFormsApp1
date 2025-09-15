namespace WindowsFormsApp1.Формы_для_добавления
{
    partial class FormSeans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодзалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодфильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDataSet = new WindowsFormsApp1.KinoteatrDataSet();
            this.сеансTableAdapter = new WindowsFormsApp1.KinoteatrDataSetTableAdapters.СеансTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсеансаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.времяначалаDataGridViewTextBoxColumn,
            this.времяокончанияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.кодзалаDataGridViewTextBoxColumn,
            this.кодфильмаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сеансBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодсеансаDataGridViewTextBoxColumn
            // 
            this.кодсеансаDataGridViewTextBoxColumn.DataPropertyName = "Код_сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.HeaderText = "Код_сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодсеансаDataGridViewTextBoxColumn.Name = "кодсеансаDataGridViewTextBoxColumn";
            this.кодсеансаDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяначалаDataGridViewTextBoxColumn
            // 
            this.времяначалаDataGridViewTextBoxColumn.DataPropertyName = "Время_начала";
            this.времяначалаDataGridViewTextBoxColumn.HeaderText = "Время_начала";
            this.времяначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяначалаDataGridViewTextBoxColumn.Name = "времяначалаDataGridViewTextBoxColumn";
            this.времяначалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяокончанияDataGridViewTextBoxColumn
            // 
            this.времяокончанияDataGridViewTextBoxColumn.DataPropertyName = "Время_окончания";
            this.времяокончанияDataGridViewTextBoxColumn.HeaderText = "Время_окончания";
            this.времяокончанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяокончанияDataGridViewTextBoxColumn.Name = "времяокончанияDataGridViewTextBoxColumn";
            this.времяокончанияDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодзалаDataGridViewTextBoxColumn
            // 
            this.кодзалаDataGridViewTextBoxColumn.DataPropertyName = "Код_зала";
            this.кодзалаDataGridViewTextBoxColumn.HeaderText = "Код_зала";
            this.кодзалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодзалаDataGridViewTextBoxColumn.Name = "кодзалаDataGridViewTextBoxColumn";
            this.кодзалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодфильмаDataGridViewTextBoxColumn
            // 
            this.кодфильмаDataGridViewTextBoxColumn.DataPropertyName = "Код_фильма";
            this.кодфильмаDataGridViewTextBoxColumn.HeaderText = "Код_фильма";
            this.кодфильмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодфильмаDataGridViewTextBoxColumn.Name = "кодфильмаDataGridViewTextBoxColumn";
            this.кодфильмаDataGridViewTextBoxColumn.Width = 170;
            // 
            // сеансBindingSource
            // 
            this.сеансBindingSource.DataMember = "Сеанс";
            this.сеансBindingSource.DataSource = this.kinoteatrDataSet;
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сеансTableAdapter
            // 
            this.сеансTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(159, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(515, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(857, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Аказа_1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 593);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSeans";
            this.Text = "Сеанс";
            this.Load += new System.EventHandler(this.Form1InsertSeans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KinoteatrDataSet kinoteatrDataSet;
        private System.Windows.Forms.BindingSource сеансBindingSource;
        private KinoteatrDataSetTableAdapters.СеансTableAdapter сеансTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn;
    }
}