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
    public partial class FormInsertBilet : Form
    {
        database database = new database();
        public FormInsertBilet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int kod_bileta = Convert.ToInt32(textBox1.Text);
                    string ryad = textBox2.Text;
                    string mesto = textBox3.Text;
                    int kod_seansa = Convert.ToInt32(textBox4.Text);
                string svobodnie_mesta_est = textBox5.Text;
                    string insertquery = $"INSERT INTO Билеты(Код_билета,Ряд,Место,Код_сеанса,Свободные_места_есть) " +
                        $"values ({kod_bileta},'{ryad}','{mesto}',{kod_seansa},'{svobodnie_mesta_est}')";
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
                Konoha home;
   
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
