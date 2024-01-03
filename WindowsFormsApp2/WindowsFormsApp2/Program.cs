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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Veritabanına bağlandık
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=B205C1; Initial Catalog=uygulama34; Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            MessageBox.Show("Bağlantı Başarılı");
            cnn.Close();
        }
        //Veritabanına bir satır ekledik
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=B205C1; Initial Catalog=uygulama34; Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            string sql, output = "";
            sql = "select * from ogrenci";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + dataReader.GetValue(1) + dataReader.GetValue(2) + "\n";
            }
            MessageBox.Show(output);
        }
        //Buton3 e her bastığımızda veritabanına bir satır daha eklenir
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=B205C1; Initial Catalog=uygulama34; Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "insert into ogrenci values('meral', 'hamarat', '5')";
            cmd = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            cnn.Dispose();
            cnn.Close();

        }
        //Veritabanından satır silmek
        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=B205C1; Initial Catalog=uygulama34; Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "delete ogrenci where numara=5";
            cmd = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            cnn.Dispose();
            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=B205C1; Initial Catalog=uygulama34; Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "update ogrenci set ogrenciadı='merve' where numara=5";
            cmd = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            cnn.Dispose();
            cnn.Close();
        }
    }
}