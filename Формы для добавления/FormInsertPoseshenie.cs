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
    public partial class FormInsertPoseshenie : Form
    {
        database database = new database();
        public FormInsertPoseshenie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod_posesheniya = Convert.ToInt32(textBox1.Text);
                string data_pechati_bileta = textBox2.Text;
                int kod_bileta = Convert.ToInt32(textBox3.Text);
                int kod_polzovatela = Convert.ToInt32(textBox4.Text);
                string insertquery = $"INSERT INTO Посещение(Код_посещения,Дата_печати_билета,Код_билета,Код_пользователя) " +
                    $"values ({kod_posesheniya},'{data_pechati_bileta}',{kod_bileta},{kod_polzovatela})";
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
