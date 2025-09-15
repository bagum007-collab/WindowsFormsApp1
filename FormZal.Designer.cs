namespace WindowsFormsApp1.Формы_для_добавления
{
    partial class FormZal
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
            this.залыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDataSet = new WindowsFormsApp1.KinoteatrDataSet();
            this.залыTableAdapter = new WindowsFormsApp1.KinoteatrDataSetTableAdapters.ЗалыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.кодзалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.схемазалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкинотеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзалаDataGridViewTextBoxColumn,
            this.количествоместDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.схемазалаDataGridViewTextBoxColumn,
            this.кодкинотеатраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.залыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // залыBindingSource
            // 
            this.залыBindingSource.DataMember = "Залы";
            this.залыBindingSource.DataSource = this.kinoteatrDataSet;
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залыTableAdapter
            // 
            this.залыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(210, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(442, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(669, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rwby_weiss_schnee_bishojo_pretty_anime_japonese_kawaii_swo_5;
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1041, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // кодзалаDataGridViewTextBoxColumn
            // 
            this.кодзалаDataGridViewTextBoxColumn.DataPropertyName = "Код_зала";
            this.кодзалаDataGridViewTextBoxColumn.HeaderText = "Код_зала";
            this.кодзалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодзалаDataGridViewTextBoxColumn.Name = "кодзалаDataGridViewTextBoxColumn";
            this.кодзалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоместDataGridViewTextBoxColumn
            // 
            this.количествоместDataGridViewTextBoxColumn.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоместDataGridViewTextBoxColumn.Name = "количествоместDataGridViewTextBoxColumn";
            this.количествоместDataGridViewTextBoxColumn.Width = 125;
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            this.площадьDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // схемазалаDataGridViewTextBoxColumn
            // 
            this.схемазалаDataGridViewTextBoxColumn.DataPropertyName = "Схема_зала";
            this.схемазалаDataGridViewTextBoxColumn.HeaderText = "Схема_зала";
            this.схемазалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.схемазалаDataGridViewTextBoxColumn.Name = "схемазалаDataGridViewTextBoxColumn";
            this.схемазалаDataGridViewTextBoxColumn.Width = 190;
            // 
            // кодкинотеатраDataGridViewTextBoxColumn
            // 
            this.кодкинотеатраDataGridViewTextBoxColumn.DataPropertyName = "Код_кинотеатра";
            this.кодкинотеатраDataGridViewTextBoxColumn.HeaderText = "Код_кинотеатра";
            this.кодкинотеатраDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодкинотеатраDataGridViewTextBoxColumn.Name = "кодкинотеатраDataGridViewTextBoxColumn";
            this.кодкинотеатраDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormZal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormZal";
            this.Text = "Залы";
            this.Load += new System.EventHandler(this.FormZal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KinoteatrDataSet kinoteatrDataSet;
        private System.Windows.Forms.BindingSource залыBindingSource;
        private KinoteatrDataSetTableAdapters.ЗалыTableAdapter залыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn схемазалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкинотеатраDataGridViewTextBoxColumn;
    }
}