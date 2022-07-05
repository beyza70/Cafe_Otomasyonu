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
    public partial class personeller : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        DataTable tablo = new DataTable();
        public personeller()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        


        public void gosterK()//Kasiyerlerrr tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form Kasiyerlerrrr", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kasiyerlerrrr", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Kasiyerlerrrr");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);

            dataGridView1.DataSource = ds.Tables["Kasiyerlerrrr"];
            conn.Close();


        }

        public void gosterG()//Garsonlarrr tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form Garsonlarrrr", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Garsonlarrrr", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Garsonlarrrr");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);

            dataGridView1.DataSource = ds.Tables["Garsonlarrrr"];
            conn.Close();


        }


        public void gosterT()//Temizlik_Personelleriiii tablosuna textboxtakı verılerı alma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form Temizlik_Personelleriiii", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Temizlik_Personelleriiii", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Temizlik_Personelleriiii");
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);

            dataGridView1.DataSource = ds.Tables["Temizlik_Personelleriiii"];
            conn.Close();


        }

        public void doldurG()//Garsonlarrrr tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Garsonlarrrr", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Garsonlarrrr");
            dataGridView1.DataSource = ds.Tables["Garsonlarrrr"];
            con.Close();
        }

        public void SilG(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM Garsonlarrrr WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void doldurK()//Kasiyerlerrrr tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Kasiyerlerrrr", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kasiyerlerrrr");
            dataGridView1.DataSource = ds.Tables["Kasiyerlerrrr"];
            con.Close();
        }

        public void SilK(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM Kasiyerlerrrr WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void doldurT()//Temizlik_personelleriiii tablosundan verı aktarma
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Temizlik_Personelleriiii", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Temizlik_Personelleriiii");
            dataGridView1.DataSource = ds.Tables["Temizlik_Personelleriiii"];
            con.Close();
        }

        public void SilT(int id)//secilen id ye göre veri silme
        {
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            string sql = "DELETE FROM Temizlik_Personelleriiii WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void personeller_Load(object sender, EventArgs e)
        {
            comboBoxPersonel.Text = "Seçiniz...";//cobobax verılerını ekleme

            comboBoxPersonel.Items.Add("Kasiyerler");
            comboBoxPersonel.Items.Add("Garsonlar");
            comboBoxPersonel.Items.Add("Temizlik Personelleri");

            //belirli bir kolon ekleme
            tablo.Columns.Add("id", typeof(int));
            tablo.Columns.Add("Cinsiyet", typeof(string));
            tablo.Columns.Add("İsim", typeof(string));
            tablo.Columns.Add("Telefon", typeof(long));
            tablo.Columns.Add("İşeBaşladığıTarih", typeof(DateTime));
            dataGridView1.DataSource = tablo;


            if (comboBoxPersonel.SelectedIndex == 0)
            {
                doldurK();
            }
            else if (comboBoxPersonel.SelectedIndex == 1)
            {
                doldurG();
            }
            else if (comboBoxPersonel.SelectedIndex == 2)
            {
                doldurT();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//secılen combobaxx a gore sql dekı belirtilen tabloyu okuma ve datagrıdvıewe ekleme

            if (comboBoxPersonel.SelectedIndex == 0)
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Kasiyerlerrrr", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "Kasiyerlerrrr");
                con.Close();
                dataGridView1.DataSource = ds.Tables["Kasiyerlerrrr"];


            }

            if (comboBoxPersonel.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Garsonlarrrr", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "Garsonlarrrr");
                con.Close();
                dataGridView1.DataSource = ds.Tables["Garsonlarrrr"];
            }

            if (comboBoxPersonel.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                DataTable dt = new DataTable();

                con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
                cmd = new SqlCommand();

                SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Temizlik_Personelleriiii", con);
                DataSet ds = new DataSet();
                con.Open();
                dda.Fill(ds, "Temizlik_Personelleriiii");
                con.Close();
                dataGridView1.DataSource = ds.Tables["Temizlik_Personelleriiii"];
            }
        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {//textboxlara girilen verileri belirli sql tablolarına aktarma
            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")//kutucuklar bos ıse uyarma
            {
                MessageBox.Show("Boş Alanları Doldurunuz !!");
            }

            else if (comboBoxPersonel.SelectedIndex == 0)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Kasiyerlerrrr (id,Cinsiyet,İsim,Telefon,İşeBaşladığıTarih) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterK();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                
                textBox1.Focus();
                
            }

            else if (comboBoxPersonel.SelectedIndex == 1)
            {


                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Garsonlarrrr (id,Cinsiyet,İsim,Telefon,İşeBaşladığıTarih) values ('"+ textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterG();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox1.Focus();

            }

            else if (comboBoxPersonel.SelectedIndex == 2)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Temizlik_Personelleriiii (id,Cinsiyet,İsim,Telefon,İşeBaşladığıTarih) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "') ", conn);

                cmd.ExecuteNonQuery();
                gosterT();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                textBox4.Clear();

                textBox1.Focus();

            }
        }


        private void sil_btn_Click(object sender, EventArgs e)//Secilen satırı sılme
        {
            if (comboBoxPersonel.SelectedIndex == 0)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    SilK(id);
                }
                doldurK();
            }

            else if (comboBoxPersonel.SelectedIndex == 1)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    SilG(id);
                }
                doldurG();
            }

            else if (comboBoxPersonel.SelectedIndex == 2)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    SilT(id);
                }
                doldurT();
            }
        }

        private void geri_btn_Click(object sender, EventArgs e)//anasayfaya gıtme
        {
            YöneticiGirisi frm = new YöneticiGirisi();
            frm.Show();
        }

        
    }
    }
