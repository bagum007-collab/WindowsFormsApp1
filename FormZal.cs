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
    public partial class FormZal : Form
    {
        database database = new database();
        public FormZal()
        {
            InitializeComponent();
        }

        private void FormZal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.kinoteatrDataSet.Залы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormInsertZal().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.залыTableAdapter.Fill(this.kinoteatrDataSet.Залы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//вывод сообщения
            {
                try
                {
                    var RowsID = dataGridView1.CurrentCell.RowIndex;
                    int ID = (int)dataGridView1.Rows[RowsID].Cells[0].Value;
                    var deleteQuery = $"delete Залы where Код_зала={ID}";
                    database.openConnection();
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();//выполнение команды
                    database.closeConnection();
                    this.залыTableAdapter.Fill(this.kinoteatrDataSet.Залы);
                    MessageBox.Show("Данные были удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

