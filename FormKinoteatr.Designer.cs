namespace WindowsFormsApp1
{
    partial class FormKinoteatr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кинотеатрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDataSet = new WindowsFormsApp1.KinoteatrDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.кинотеатрTableAdapter = new WindowsFormsApp1.KinoteatrDataSetTableAdapters.КинотеатрTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.кодкинотеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрескинотеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электроннаяпочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(152, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Crimson;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкинотеатраDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.адрескинотеатраDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.электроннаяпочтаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.кинотеатрBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 515);
            this.dataGridView1.TabIndex = 4;
            // 
            // кинотеатрBindingSource
            // 
            this.кинотеатрBindingSource.DataMember = "Кинотеатр";
            this.кинотеатрBindingSource.DataSource = this.kinoteatrDataSet;
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(893, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 77);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(539, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 77);
            this.button2.TabIndex = 6;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // кинотеатрTableAdapter
            // 
            this.кинотеатрTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.bdb45c8a7fbb3155db7ab9a713cc1688;
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1178, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // кодкинотеатраDataGridViewTextBoxColumn
            // 
            this.кодкинотеатраDataGridViewTextBoxColumn.DataPropertyName = "Код_кинотеатра";
            this.кодкинотеатраDataGridViewTextBoxColumn.HeaderText = "Код_кинотеатра";
            this.кодкинотеатраDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодкинотеатраDataGridViewTextBoxColumn.Name = "кодкинотеатраDataGridViewTextBoxColumn";
            this.кодкинотеатраDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // адрескинотеатраDataGridViewTextBoxColumn
            // 
            this.адрескинотеатраDataGridViewTextBoxColumn.DataPropertyName = "Адрес_кинотеатра";
            this.адрескинотеатраDataGridViewTextBoxColumn.HeaderText = "Адрес_кинотеатра";
            this.адрескинотеатраDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адрескинотеатраDataGridViewTextBoxColumn.Name = "адрескинотеатраDataGridViewTextBoxColumn";
            this.адрескинотеатраDataGridViewTextBoxColumn.Width = 135;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // электроннаяпочтаDataGridViewTextBoxColumn
            // 
            this.электроннаяпочтаDataGridViewTextBoxColumn.DataPropertyName = "Электронная_почта";
            this.электроннаяпочтаDataGridViewTextBoxColumn.HeaderText = "Электронная_почта";
            this.электроннаяпочтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.электроннаяпочтаDataGridViewTextBoxColumn.Name = "электроннаяпочтаDataGridViewTextBoxColumn";
            this.электроннаяпочтаDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormKinoteatr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormKinoteatr";
            this.Text = "Кинотеатр";
            this.Load += new System.EventHandler(this.FormKinoteatr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private KinoteatrDataSet kinoteatrDataSet;
        private System.Windows.Forms.BindingSource кинотеатрBindingSource;
        private KinoteatrDataSetTableAdapters.КинотеатрTableAdapter кинотеатрTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкинотеатраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрескинотеатраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электроннаяпочтаDataGridViewTextBoxColumn;
    }
}