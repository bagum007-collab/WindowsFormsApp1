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
    public partial class FormInsertKinoteatr : Form
    {
        database database = new database();
        public FormInsertKinoteatr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod_kinoteatra = Convert.ToInt32(textBox1.Text);
                string nazvanie = textBox2.Text;
                string adres_kinotatra = textBox3.Text;
                string telefon = textBox4.Text;
                string el_pochta = textBox5.Text;
                string insertquery = $"INSERT INTO Кинотеатр(Код_кинотеатра,Название,Адрес_кинотеатра,Телефон,Электронная_почта) " +
                    $"values ({kod_kinoteatra},'{nazvanie}','{adres_kinotatra}',{telefon},'{el_pochta}')";
                database.openConnection();
                var command = new SqlCommand(insertquery, database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Данные были добавлены");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

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
