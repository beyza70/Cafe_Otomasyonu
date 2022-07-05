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
    public partial class menüler : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        DataTable tablo = new DataTable();
        public menüler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
       
        public void gosterİ()//İçecekler tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form İcecekler", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM İcecekler", conn);
            DataSet ds = new DataSet();
            
            da.Fill(ds, "İcecekler");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
          
            dataGridViewMenüler.DataSource = ds.Tables["İcecekler"];
            conn.Close();

            
        }

        public void gosterY()//Yiyecekler tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form Yiyecekler", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Yiyecekler", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Yiyecekler");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

            dataGridViewMenüler.DataSource = ds.Tables["Yiyecekler"];
            conn.Close();


        }

        public void gosterT()//tatlılar tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form Tatlılar", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tatlılar", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Tatlılar");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

            dataGridViewMenüler.DataSource = ds.Tables["Tatlılar"];
            conn.Close();


        }

        public void doldurY()//Yiyecekler tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Yiyecekler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Yiyecekler");
            dataGridViewMenüler.DataSource = ds.Tables["Yiyecekler"];
            con.Close();
        }

        public void SilY(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM Yiyecekler WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void doldurİ()//İçecekler tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM İcecekler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "İcecekler");
            dataGridViewMenüler.DataSource = ds.Tables["İcecekler"];
            con.Close();
        }

        public void Silİ(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM İcecekler WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void doldurT()//tatlılar tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Tatlılar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tatlılar");
            dataGridViewMenüler.DataSource = ds.Tables["Tatlılar"];
            con.Close();
        }

        public void SilT(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM Tatlılar WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void menüler_Load_1(object sender, EventArgs e)
        {
            comboBoxMenülerr.Text = "Seçiniz...";//cobobax verılerını ekleme

            comboBoxMenülerr.Items.Add("Yiyecekler");
            comboBoxMenülerr.Items.Add("İçecekler");
            comboBoxMenülerr.Items.Add("Tatlılar");

            //belirli bir kolon ekleme
            tablo.Columns.Add("id", typeof(int));
            tablo.Columns.Add("İsim", typeof(string));
            tablo.Columns.Add("Fiyat", typeof(int));
 
            dataGridViewMenüler.DataSource = tablo;


            if (comboBoxMenülerr.SelectedIndex == 0)
            {
                doldurY();
            }
           else if (comboBoxMenülerr.SelectedIndex == 1)
            {
                doldurİ();
            }
            else if (comboBoxMenülerr.SelectedIndex == 2)
            {
                doldurT();
            }

        }

        private void comboBoxMenülerr_SelectedIndexChanged(object sender, EventArgs e)
        {//secılen combobaxx a gore sql dekı belirtilen tabloyu okuma ve datagrıdvıewe ekleme

            if (comboBoxMenülerr.SelectedIndex == 0)
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Yiyecekler", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "Yiyecekler");
                con.Close();
                dataGridViewMenüler.DataSource = ds.Tables["Yiyecekler"];


            }

            if (comboBoxMenülerr.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM İcecekler", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "İcecekler");
                con.Close();
                dataGridViewMenüler.DataSource = ds.Tables["İcecekler"];
            }

            if (comboBoxMenülerr.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Tatlılar", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "Tatlılar");
                con.Close();
                dataGridViewMenüler.DataSource = ds.Tables["Tatlılar"];
            }
        }

        private void buttoncikis_Click(object sender, EventArgs e)//ana sayfaya gıtme
        {
            YöneticiGirisi frm = new YöneticiGirisi();
            frm.Show();
        }


        private void Sil_btn_Click(object sender, EventArgs e)//Secilen satırı sılme
        {
            if (comboBoxMenülerr.SelectedIndex == 0)
            {
                foreach (DataGridViewRow drow in dataGridViewMenüler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    SilY(id);
                }
                doldurY();
            }

            else if (comboBoxMenülerr.SelectedIndex == 1)
            {
                foreach (DataGridViewRow drow in dataGridViewMenüler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    Silİ(id);
                }
                doldurİ();
            }

           else if (comboBoxMenülerr.SelectedIndex == 2)
            {
                foreach (DataGridViewRow drow in dataGridViewMenüler.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    SilT(id);
                }
                doldurT();
            }


        }

        

        private void Ekle_btn_Click(object sender, EventArgs e)
        {//textboxlara girilen verileri belirli sql tablolarına aktarma
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )//kutucuklar bos ıse uyarma
            {
                MessageBox.Show("Boş Alanları Doldurunuz !!");
            }
            else if (comboBoxMenülerr.SelectedIndex == 0)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();
                
                SqlCommand cmd = new SqlCommand("insert into Yiyecekler (id,isim,Fiyat) values  ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterY();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

            }

            else if (comboBoxMenülerr.SelectedIndex == 1)
            {
                
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();
                
                SqlCommand cmd = new SqlCommand("insert into İcecekler (id,isim,Fiyat) values  ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterİ();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }

            else if (comboBoxMenülerr.SelectedIndex == 2)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Tatlılar (id,isim,Fiyat) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterT();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }

        }

      
    }
}

