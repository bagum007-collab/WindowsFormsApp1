namespace WindowsFormsApp1.Формы_для_добавления
{
    partial class FormBilet
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
            this.кодбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рядDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.свободныеместаестьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.билетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDataSet = new WindowsFormsApp1.KinoteatrDataSet();
            this.билетыTableAdapter = new WindowsFormsApp1.KinoteatrDataSetTableAdapters.БилетыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодбилетаDataGridViewTextBoxColumn,
            this.рядDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn,
            this.кодсеансаDataGridViewTextBoxColumn,
            this.свободныеместаестьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.билетыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодбилетаDataGridViewTextBoxColumn
            // 
            this.кодбилетаDataGridViewTextBoxColumn.DataPropertyName = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.HeaderText = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодбилетаDataGridViewTextBoxColumn.Name = "кодбилетаDataGridViewTextBoxColumn";
            this.кодбилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // рядDataGridViewTextBoxColumn
            // 
            this.рядDataGridViewTextBoxColumn.DataPropertyName = "Ряд";
            this.рядDataGridViewTextBoxColumn.HeaderText = "Ряд";
            this.рядDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рядDataGridViewTextBoxColumn.Name = "рядDataGridViewTextBoxColumn";
            this.рядDataGridViewTextBoxColumn.Width = 125;
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            this.местоDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодсеансаDataGridViewTextBoxColumn
            // 
            this.кодсеансаDataGridViewTextBoxColumn.DataPropertyName = "Код_сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.HeaderText = "Код_сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодсеансаDataGridViewTextBoxColumn.Name = "кодсеансаDataGridViewTextBoxColumn";
            this.кодсеансаDataGridViewTextBoxColumn.Width = 125;
            // 
            // свободныеместаестьDataGridViewTextBoxColumn
            // 
            this.свободныеместаестьDataGridViewTextBoxColumn.DataPropertyName = "Свободные_места_есть";
            this.свободныеместаестьDataGridViewTextBoxColumn.HeaderText = "Свободные_места_есть";
            this.свободныеместаестьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.свободныеместаестьDataGridViewTextBoxColumn.Name = "свободныеместаестьDataGridViewTextBoxColumn";
            this.свободныеместаестьDataGridViewTextBoxColumn.Width = 170;
            // 
            // билетыBindingSource
            // 
            this.билетыBindingSource.DataMember = "Билеты";
            this.билетыBindingSource.DataSource = this.kinoteatrDataSet;
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(522, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(818, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(229, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.e58bb655ae592bdc37136d910dfff69c;
            this.pictureBox1.Location = new System.Drawing.Point(1, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormBilet";
            this.Text = "Билет";
            this.Load += new System.EventHandler(this.FormInsertBilet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KinoteatrDataSet kinoteatrDataSet;
        private System.Windows.Forms.BindingSource билетыBindingSource;
        private KinoteatrDataSetTableAdapters.БилетыTableAdapter билетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рядDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn свободныеместаестьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}