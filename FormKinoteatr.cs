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
using WindowsFormsApp1.Формы_для_добавления;

namespace WindowsFormsApp1
{
    public partial class FormKinoteatr : Form
    {
        database database = new database();
        public FormKinoteatr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormInsertKinoteatr().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.кинотеатрTableAdapter.Fill(this.kinoteatrDataSet.Кинотеатр);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//вывод сообщения
            {
                try
                {
                    var RowsID = dataGridView1.CurrentCell.RowIndex;
                    int ID = (int)dataGridView1.Rows[RowsID].Cells[0].Value;
                    var deleteQuery = $"delete Кинотеатр where Код_кинотеатра={ID}";
                    database.openConnection();
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();//выполнение команды
                    database.closeConnection();
                    this.кинотеатрTableAdapter.Fill(this.kinoteatrDataSet.Кинотеатр);
                    MessageBox.Show("Данные были удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormKinoteatr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.kinoteatrDataSet.Кинотеатр);

        }
    }
}
    

