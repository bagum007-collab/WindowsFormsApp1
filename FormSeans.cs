using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы_для_добавления
{
    public partial class FormSeans : Form
    {
        database database = new database();
        public FormSeans()
        {
            InitializeComponent();
        }

        private void Form1InsertSeans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDataSet.Сеанс". При необходимости она может быть перемещена или удалена.
            this.сеансTableAdapter.Fill(this.kinoteatrDataSet.Сеанс);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormInsertSeans().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сеансTableAdapter.Fill(this.kinoteatrDataSet.Сеанс);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//вывод сообщения
            {
                try
                {
                    var RowsID = dataGridView1.CurrentCell.RowIndex;
                    int ID = (int)dataGridView1.Rows[RowsID].Cells[0].Value;
                    var deleteQuery = $"delete Сеанс where Код_сеанса={ID}";
                    database.openConnection();
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();//выполнение команды
                    database.closeConnection();
                    this.сеансTableAdapter.Fill(this.kinoteatrDataSet.Сеанс);
                    MessageBox.Show("Данные были удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

