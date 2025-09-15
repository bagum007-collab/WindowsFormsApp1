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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Формы_для_добавления
{
    public partial class FormInsertPolzovatel : Form
    {
        database database = new database();
        public FormInsertPolzovatel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod_polzovatela = Convert.ToInt32(textBox1.Text);
                string FIO = textBox2.Text;
                string telefon = textBox3.Text;
                string el_pochta = textBox4.Text;
                string insertquery = $"INSERT INTO Пользователь(Код_пользователя,ФИО,Телефон,Электронная_почта) " +
                    $"values ({kod_polzovatela},'{FIO}','{telefon}','{el_pochta}')";
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
