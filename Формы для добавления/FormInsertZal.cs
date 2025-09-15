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
    public partial class FormInsertZal : Form
    {
        database database = new database();
        public FormInsertZal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod_zala = Convert.ToInt32(textBox1.Text);
                string kolichestvo_mest = textBox2.Text;
                string ploshad = textBox3.Text;
                string nazvanie = textBox4.Text; ; ;
                string shema_zala = textBox5.Text;
                int kod_kinoteatra = Convert.ToInt32(textBox6.Text);
                string insertquery = $"INSERT INTO Залы(Код_зала,Количество_мест,Площадь,Название,СХема_зала,Код_кинотеатра) " +
                    $"values ({kod_zala},'{kolichestvo_mest}','{ploshad}','{nazvanie}','{shema_zala}',{kod_kinoteatra})";
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
