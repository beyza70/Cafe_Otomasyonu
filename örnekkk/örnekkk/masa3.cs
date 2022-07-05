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


    public partial class masa3 : Form
    {
        //sql baglantı ıcın kullanılanlar
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataSet ds;
        public masa3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        //(Sql cafeOtomasyonu tabloları ıle baglantı)
        private void masa3_Load(object sender, EventArgs e)
        {
            comboBoxMenü.Text = "Seçiniz...";//combobax veri ekleme
            comboBoxMenü.Items.Add("Yiyecekler");
            comboBoxMenü.Items.Add("İçecekler");
            comboBoxMenü.Items.Add("Tatlılar");

            dataGridView_Sepet.ColumnCount = 3;//belirli bir kolonlar ekleme
            dataGridView_Sepet.Columns[0].Name = "id";
            dataGridView_Sepet.Columns[1].Name = "isim";
            dataGridView_Sepet.Columns[2].Name = "Fiyat";

            this.dataGridView_Menü.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//datagrıdvıewde tum satırı secme
            this.dataGridView_Menü.MultiSelect = false;

            this.dataGridView_Sepet.MultiSelect = true;

            this.dataGridView_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sepet.MultiSelect = false;




        }





        private void comboBoxMenü_SelectedIndexChanged(object sender, EventArgs e)
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
                dataGridView_Menü.DataSource = ds.Tables["Yiyecekler"];


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
                dataGridView_Menü.DataSource = ds.Tables["İcecekler"];
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
                dataGridView_Menü.DataSource = ds.Tables["Tatlılar"];
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)//Secılen menuyu menulerden sepete ekleme
        {
            foreach (DataGridViewRow row in dataGridView_Menü.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }

                this.dataGridView_Sepet.Rows.Add(rowData);
            }

        }

        private void btn_fytHesapla_Click(object sender, EventArgs e)//Toplam tutarı hesaplama
        {
            int toplam = 0;

            for (int i = 0; i < dataGridView_Sepet.Rows.Count; i++)
            {

                toplam += Convert.ToInt32(dataGridView_Sepet.Rows[i].Cells[2].Value);
            }
            textBoxTutar.Text = toplam.ToString();



        }

        private void btn_cikisss_Click(object sender, EventArgs e)//ana sayfaya gıtme
        {
            YöneticiGirisi frm = new YöneticiGirisi();
            frm.Show();
        }

        public void gosterY()//masa2 ın sepettekılerı sqldekı sıparıs 3 tablosuna aktarma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form siparis3", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM siparis3", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "siparis3");


            dataGridView_Sepet.DataSource = ds.Tables["siparis3"];
            conn.Close();


        }

        private void btn_siparisvr_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow satirr in dataGridView_Menü.SelectedRows)//sıparıs ver butonu ıle secılen menulerı sıparıs3 menusune aktarma
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into siparis3 (isim,Fiyat) values (@isim,@Fiyat) ", conn);

                cmd.Parameters.AddWithValue("@isim", satirr.Cells["isim"].Value.ToString());
                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
                gosterY();

            }

            foreach (DataGridViewRow satirr in dataGridView_Menü.SelectedRows)//sıparıslerın toplam tutarını masa3kasa tablosuna aktarma
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into masa3kasa (Fiyat) values (@Fiyat) ", conn);

              
                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
                gosterY();

            }

            MessageBox.Show("Siparişiniz Alınmıştır.Siparişler bölümünden bakabilirsiniz.");
        }

        
    }


}