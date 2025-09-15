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

    public partial class Film : Form
    {
        database database=new database();  
        public Film()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.kinoteatrDataSet.Фильмы);

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {

            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.фильмыTableAdapter.Fill(this.kinoteatrDataSet.Фильмы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormInsertFilm formInsertFilm = new FormInsertFilm();
            formInsertFilm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//вывод сообщения
            {
                try
                {
                    var RowsID = dataGridView1.CurrentCell.RowIndex;
                    int ID = (int)dataGridView1.Rows[RowsID].Cells[0].Value;
                    var deleteQuery = $"delete Фильмы where Код_фильма={ID}";
                    database.openConnection();
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();//выполнение команды
                    database.closeConnection();
                    this.фильмыTableAdapter.Fill(this.kinoteatrDataSet.Фильмы);
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
                
    
        
 
