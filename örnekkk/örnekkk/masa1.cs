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


    public partial class masa1 : Form
    {
        //sql baglantı ıcın kullanılanlar
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataSet ds;
        public masa1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        //(Sql cafeOtomasyonu tabloları ıle baglantı
        private void masa1_Load_1(object sender, EventArgs e)
        {
            comboBoxMenü.Text = "Seçiniz...";//combobax veri ekleme
            comboBoxMenü.Items.Add("Yiyecekler");
            comboBoxMenü.Items.Add("İçecekler");
            comboBoxMenü.Items.Add("Tatlılar");

            dataGridViewSepet.ColumnCount = 3;//belirli bir kolonlar ekleme
            dataGridViewSepet.Columns[0].Name = "id";
            dataGridViewSepet.Columns[1].Name = "isim";
            dataGridViewSepet.Columns[2].Name = "Fiyat";

            this.dataGridViewMenü.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//datagrıdvıewde tum satırı secme
            this.dataGridViewMenü.MultiSelect = false;

            this.dataGridViewSepet.MultiSelect = true;

            this.dataGridViewSepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSepet.MultiSelect = false;


           

        }





        private void comboBoxMenü_SelectedIndexChanged_1(object sender, EventArgs e)
        {//secılen combobaxx a gore sql dekı belirtilen tabloyu okuma ve datagrıdvıewe ekleme
            if (comboBoxMenü.SelectedIndex == 0)
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
                dataGridViewMenü.DataSource = ds.Tables["Yiyecekler"];


            }

            if (comboBoxMenü.SelectedIndex == 1)
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
                dataGridViewMenü.DataSource = ds.Tables["İcecekler"];
            }

            if (comboBoxMenü.SelectedIndex == 2)
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
                dataGridViewMenü.DataSource = ds.Tables["Tatlılar"];
            }
        }

        private void buttonEkle_Click_1(object sender, EventArgs e)//Secılen menuyu menulerden sepete ekleme
        {
            foreach (DataGridViewRow row in dataGridViewMenü.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }

                this.dataGridViewSepet.Rows.Add(rowData);
            }

        }

        private void btnfiyathesapla_Click(object sender, EventArgs e)//Toplam tutarı hesaplama
        {
            int toplam = 0;

            for (int i = 0; i < dataGridViewSepet.Rows.Count; i++)//verı sayısına kadar
            {

                toplam += Convert.ToInt32(dataGridViewSepet.Rows[i].Cells[2].Value);
            }
            textBoxTutar.Text = toplam.ToString();



        }

        private void btncikiss_Click(object sender, EventArgs e)//Çıkıs butonu ıle ana sayfaya gıtme
        {
            YöneticiGirisi frm = new YöneticiGirisi();
            frm.Show();
        }

        public void gosterY()//masa1 ın sepettekılerı sqldekı sıparıs 1 tablosuna aktarma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form siparis1", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM siparis1", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "siparis1");


            dataGridViewSepet.DataSource = ds.Tables["siparis1"];
            conn.Close();


        }

        private void btn_siparısver_Click_1(object sender, EventArgs e)//sıparıs ver butonu ıle secılen menulerı sıparıs1 menusune aktarma
        {
            foreach (DataGridViewRow satirr in dataGridViewMenü.SelectedRows)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into siparis1 (isim,Fiyat) values (@isim,@Fiyat) ", conn);

                cmd.Parameters.AddWithValue("@isim", satirr.Cells["isim"].Value.ToString());
                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
                gosterY();

            }
            foreach (DataGridViewRow satirr in dataGridViewMenü.SelectedRows)//sıparıslerın toplam tutarını masa1kasa tablosuna aktarma
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into masa1kasa (Fiyat) values (@Fiyat) ", conn);


                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
                gosterY();

            }

            MessageBox.Show("Siparişiniz Alınmıştır.Siparişler bölümünden bakabilirsiniz.");
        }

       

        
    }


}
