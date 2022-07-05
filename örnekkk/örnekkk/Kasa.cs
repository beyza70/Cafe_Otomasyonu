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
    public partial class Kasa : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataSet ds;
        public Kasa()
        {
            InitializeComponent();
        }

        private void dataGridViewsiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            comboBoxKasa.Text = "Seçiniz...";//combobax a veri ekleme
            comboBoxKasa.Items.Add("Masa 1");
            comboBoxKasa.Items.Add("Masa 2");
            comboBoxKasa.Items.Add("Masa 3");
          

           

            if (comboBoxKasa.SelectedIndex == 0)
            {
                doldur1();
            }
            else if (comboBoxKasa.SelectedIndex == 1)
            {
                doldur2();
            }
            else if (comboBoxKasa.SelectedIndex == 2)
            {
                doldur3();
            }
        }

        private void comboBoxKasa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxKasa.SelectedIndex == 0)
            {//masa1 ın siparis fiyatını sql de masa1kasa tablosundan alma

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM masa1kasa", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "masa1kasa");
                con.Close();
                dataGridViewKasa.DataSource = ds.Tables["masa1kasa"];


            }

            if (comboBoxKasa.SelectedIndex == 1)
            {//masa2 ın siparis fiyatını sql de masa2kasa tablosundan alma

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM masa2kasa", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "masa2kasa");
                con.Close();
                dataGridViewKasa.DataSource = ds.Tables["masa2kasa"];


            }
            if (comboBoxKasa.SelectedIndex == 2)
            {//masa3 ın siparis fiyatını sql de masa3kasa tablosundan alma

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM masa3kasa", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "masa3kasa");
                con.Close();
                dataGridViewKasa.DataSource = ds.Tables["masa3kasa"];


            }

        }
        public void Sil1(int id)
        {//masa1 sılme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM masa1kasa WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur1()
        {//masa1 ekleme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM masa1kasa", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "masa1kasa");
            dataGridViewKasa.DataSource = ds.Tables["masa1kasa"];
            con.Close();
        }
        public void Sil2(int id)
        {//masa2 sılme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM masa2kasa WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur2()
        {//masa2 ekleme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM masa2kasa", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "masa2kasa");
            dataGridViewKasa.DataSource = ds.Tables["masa2kasa"];
            con.Close();
        }
        public void Sil3(int id)
        {//masa3 sılme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM masa3kasa WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void doldur3()
        {//masa3 ekleme fonksıyonu
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM masa3kasa", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "masa3kasa");
            dataGridViewKasa.DataSource = ds.Tables["masa3kasa"];
            con.Close();
        }
        private void sil_btn_Click(object sender, EventArgs e)
        {//secılen combobaxa gore secılen verıyı sılme
            if (comboBoxKasa.SelectedIndex == 0)
            {
                foreach (DataGridViewRow drow in dataGridViewKasa.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil1(id);
                }
                doldur1();
            }
            if (comboBoxKasa.SelectedIndex == 1)
            {
                foreach (DataGridViewRow drow in dataGridViewKasa.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil2(id);
                }
                doldur2();
            }
            if (comboBoxKasa.SelectedIndex == 2)
            {
                foreach (DataGridViewRow drow in dataGridViewKasa.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Sil3(id);
                }
                doldur3();
            }
        }

        
    }
}
