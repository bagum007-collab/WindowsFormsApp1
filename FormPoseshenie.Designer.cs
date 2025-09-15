namespace WindowsFormsApp1.Формы_для_добавления
{
    partial class FormPoseshenie
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
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDataSet = new WindowsFormsApp1.KinoteatrDataSet();
            this.посещениеTableAdapter = new WindowsFormsApp1.KinoteatrDataSetTableAdapters.ПосещениеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.кодпосещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапечатибилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпосещенияDataGridViewTextBoxColumn,
            this.датапечатибилетаDataGridViewTextBoxColumn,
            this.кодбилетаDataGridViewTextBoxColumn,
            this.кодпользователяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.посещениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // посещениеBindingSource
            // 
            this.посещениеBindingSource.DataMember = "Посещение";
            this.посещениеBindingSource.DataSource = this.kinoteatrDataSet;
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещениеTableAdapter
            // 
            this.посещениеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(154, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(431, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(701, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Эн_Такамаки__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // кодпосещенияDataGridViewTextBoxColumn
            // 
            this.кодпосещенияDataGridViewTextBoxColumn.DataPropertyName = "Код_посещения";
            this.кодпосещенияDataGridViewTextBoxColumn.HeaderText = "Код_посещения";
            this.кодпосещенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпосещенияDataGridViewTextBoxColumn.Name = "кодпосещенияDataGridViewTextBoxColumn";
            this.кодпосещенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // датапечатибилетаDataGridViewTextBoxColumn
            // 
            this.датапечатибилетаDataGridViewTextBoxColumn.DataPropertyName = "Дата_печати_билета";
            this.датапечатибилетаDataGridViewTextBoxColumn.HeaderText = "Дата_печати_билета";
            this.датапечатибилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датапечатибилетаDataGridViewTextBoxColumn.Name = "датапечатибилетаDataGridViewTextBoxColumn";
            this.датапечатибилетаDataGridViewTextBoxColumn.Width = 170;
            // 
            // кодбилетаDataGridViewTextBoxColumn
            // 
            this.кодбилетаDataGridViewTextBoxColumn.DataPropertyName = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.HeaderText = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодбилетаDataGridViewTextBoxColumn.Name = "кодбилетаDataGridViewTextBoxColumn";
            this.кодбилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпользователяDataGridViewTextBoxColumn
            // 
            this.кодпользователяDataGridViewTextBoxColumn.DataPropertyName = "Код_пользователя";
            this.кодпользователяDataGridViewTextBoxColumn.HeaderText = "Код_пользователя";
            this.кодпользователяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпользователяDataGridViewTextBoxColumn.Name = "кодпользователяDataGridViewTextBoxColumn";
            this.кодпользователяDataGridViewTextBoxColumn.Width = 190;
            // 
            // FormPoseshenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPoseshenie";
            this.Text = "Посещение";
            this.Load += new System.EventHandler(this.Form1InsertPoseshenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KinoteatrDataSet kinoteatrDataSet;
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private KinoteatrDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпосещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапечатибилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпользователяDataGridViewTextBoxColumn;
    }
}