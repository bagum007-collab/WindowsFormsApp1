using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Формы_для_добавления
{
    public partial class FormInsertFilm : Form
    {
        database database=new database();
        public FormInsertFilm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id=Convert.ToInt32(textBox1.Text);
                string god=textBox2.Text; 
                string nazvanie=textBox3.Text;
                string strana=textBox4.Text;
                string time = maskedTextBox1.Text;
                string reshiser = textBox6.Text;
                string kinostudia=textBox7.Text;
                string insertquery = $"INSERT INTO Фильмы(Код_фильма,Год_выпуска,Название,Страна,Продолжительность,Режисёр,Киностудия) " +
                    $"values ({id},'{god}','{nazvanie}','{strana}','{time}','{reshiser}','{kinostudia}')";
                database.openConnection();
                var command = new SqlCommand(insertquery,database.getConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Данные были добавлены");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
