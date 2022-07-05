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

namespace örnekkk
{
    public partial class siparisler : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataSet ds;
        public siparisler()
        {
            InitializeComponent();
        }
       
        private void dataGridViewsiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            comboBoxsiparisler.Text = "Seçiniz...";//combobax a veri ekleme
            comboBoxsiparisler.Items.Add("Masa 1");
            comboBoxsiparisler.Items.Add("Masa 2");
            comboBoxsiparisler.Items.Add("Masa 3");
            

         

            if (comboBoxsiparisler.SelectedIndex == 0)
            {
                doldur1();
            }
            else if (comboBoxsiparisler.SelectedIndex == 1)
            {
                doldur2();
            }
            else if (comboBoxsiparisler.SelectedIndex == 2)
            {
                doldur3();
            }
        }

        private void comboBoxsiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {//siparisleri belirli tablolardan  alma

            if (comboBoxsiparisler.SelectedIndex == 0)
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM siparis1", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "siparis1");
                con.Close();
                dataGridViewsiparisler.DataSource = ds.Tables["siparis1"];
                

            }

            if (comboBoxsiparisler.SelectedIndex == 1)
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM siparis2", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "siparis2");
                con.Close();
                dataGridViewsiparisler.DataSource = ds.Tables["siparis2"];


            }
            if (comboBoxsiparisler.SelectedIndex == 2)
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM siparis3", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "siparis3");
                con.Close();
                dataGridViewsiparisler.DataSource = ds.Tables["siparis3"];


            }

        }
        public void Sil1(int id)//secilien satırı sılme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM siparis1 WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur1()//siparis1 ekleme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM siparis1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparis1");
            dataGridViewsiparisler.DataSource = ds.Tables["siparis1"];
            con.Close();
        }
        public void Sil2(int id)//secilien satırı sılme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM siparis2 WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur2()//siparis2 ekleme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM siparis2", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparis2");
            dataGridViewsiparisler.DataSource = ds.Tables["siparis2"];
            con.Close();
        }
        public void Sil3(int id)//secilien satırı sılme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM siparis3 WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur3()//siparis3 ekleme fonksiyonu
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM siparis3", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "siparis3");
            dataGridViewsiparisler.DataSource = ds.Tables["siparis3"];
            con.Close();
        }
        

        private void SilmeButonu_Click(object sender, EventArgs e)//secilien satırı sılme işlemi
        {
            if (comboBoxsiparisler.SelectedIndex == 0)
            {
                foreach (DataGridViewRow drow in dataGridViewsiparisler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil1(id);
                }
                doldur1();
            }

            else if (comboBoxsiparisler.SelectedIndex == 1)
            {
                foreach (DataGridViewRow drow in dataGridViewsiparisler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil2(id);
                }
                doldur2();
            }

            else if (comboBoxsiparisler.SelectedIndex == 2)
            {
                foreach (DataGridViewRow drow in dataGridViewsiparisler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil3(id);
                }
                doldur3();
            }
        }
    }
}
