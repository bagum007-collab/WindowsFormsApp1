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
    public partial class FormInsertSeans : Form
    {
        database database = new database();
        public FormInsertSeans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod_seansa = Convert.ToInt32(textBox1.Text);
                string stoimosti = textBox2.Text;
               string vremya_nachala = maskedTextBox1.Text;
                string vremya_okonchaniya = maskedTextBox2.Text; ;
                string data= dateTimePicker1.Value.ToShortDateString();
                int kod_zala= Convert.ToInt32(textBox3.Text);
                int kod_filma= Convert.ToInt32(textBox4.Text);
                string insertquery = $"INSERT INTO Сеанс(Код_сеанса,Стоимость,Время_начала,Время_окончания,Дата,Код_зала,Код_фильма) " +
                    $"values ({kod_seansa},'{stoimosti}','{vremya_nachala}','{vremya_okonchaniya}','{data}',{kod_zala},{kod_filma})";
                database.openConnection();
                var command = new SqlCommand(insertquery, database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Данные были добавлены");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
