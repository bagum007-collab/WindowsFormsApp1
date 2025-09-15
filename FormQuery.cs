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

namespace WindowsFormsApp1
{
    public partial class FormQuery : Form
    {
        database database= new database();
        public FormQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            SqlDataAdapter da = new SqlDataAdapter("select Кинотеатр.Название as [Кинотеатр],Кинотеатр.Адрес_кинотеатра," +
                "Залы.Название as [Зал],Залы.Количество_мест,Сеанс.Стоимость," +
                "Сеанс.Время_начала,Сеанс.Время_окончания,Фильмы.Название as [Фильм]," +
                "Фильмы.Продолжительность\r\nfrom Кинотеатр\r\ninner join Залы on Кинотеатр.Код_кинотеатра=Залы.Код_кинотеатра\r\n" +
                "inner join Сеанс on Залы.Код_зала=Сеанс.Код_зала\r\n" +
                "inner join Фильмы on Фильмы.Код_фильма=Сеанс.Код_фильма", database.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Билеты");

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[8].Width = 115;
            database.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.openConnection();
            SqlDataAdapter da = new SqlDataAdapter("select Пользователь.ФИО,Посещение.Дата_печати_билета,Билеты.Ряд,Билеты.Место,Сеанс.Стоимость," +
                "Сеанс.Время_начала,Сеанс.Время_окончания,Сеанс.Дата as[Дата сеанса],Фильмы.Название,Фильмы.Продолжительность\r\n" +
                "from Пользователь\r\ninner join Посещение on Пользователь.Код_пользователя=Посещение.Код_пользователя\r\n" +
                "inner join Билеты on Билеты.Код_билета=Посещение.Код_билета\r\ninner join Сеанс on Сеанс.Код_сеанса=Билеты.Код_сеанса\r\n" +
                "inner join Фильмы on Фильмы.Код_фильма=Сеанс.Код_фильма", database.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Пользователь");

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 190;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[8].Width = 115;
            dataGridView1.Columns[9].Width = 115;
            database.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database.openConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from Фильмы where Фильмы.Страна='"+comboBox1.Text+"'", database.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Фильмы");

            dataGridView1.DataSource = ds.Tables[0];
            database.closeConnection();
        }

        private void FormQuery_Load(object sender, EventArgs e)
        {
            string Sql = "select distinct Фильмы.Страна\r\nfrom Фильмы";
            database.openConnection();
            SqlCommand cmd = new SqlCommand(Sql, database.getConnection());
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
            comboBox1.SelectedIndex = 0;
            DR.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database.openConnection();
            SqlDataAdapter da = new SqlDataAdapter("select Сеанс.Время_начала,Сеанс.Время_окончания,Сеанс.Дата,Сеанс.Стоимость\r\nfrom Сеанс\r\nwhere Сеанс.Код_фильма in (select Фильмы.Код_фильма from Фильмы  where Фильмы.Продолжительность>'02:00:00')", database.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Сеансы больше 2-х часов");
            dataGridView1.DataSource = ds.Tables[0];
            database.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            database.openConnection();
            SqlDataAdapter da = new SqlDataAdapter("select min(Продолжительность) as [Минимальная продолжительность фильма], max(Продолжительность) as [Максимальная продолжительность фильма],count (Продолжительность) as [Количество фильмов] from Фильмы", database.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Агрегатные операции");

            dataGridView1.DataSource = ds.Tables[0];
            database.closeConnection();
        }
    }
    }

