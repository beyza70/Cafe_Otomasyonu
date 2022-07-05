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
    

    public partial class masa2 : Form
    {
        //sql baglantı ıcın kullanılanlar
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataSet ds;
        public masa2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        //(Sql cafeOtomasyonu tabloları ıle baglantı)
        public bool MultiSelecet { get; set; }
        private void masa2_Load(object sender, EventArgs e)
        {
            comboBoxMenü.Text = "Seçiniz...";//combobax veri ekleme
            comboBoxMenü.Items.Add("Yiyecekler");
            comboBoxMenü.Items.Add("İçecekler");
            comboBoxMenü.Items.Add("Tatlılar");

            dataGridViewSepett.ColumnCount = 3;//belirli bir kolonlar ekleme
            dataGridViewSepett.Columns[0].Name = "id";
            dataGridViewSepett.Columns[1].Name = "isim";
            dataGridViewSepett.Columns[2].Name = "Fiyat";


            this.dataGridViewMenüü.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//datagrıdvıewde tum satırı secme
            this.dataGridViewMenüü.MultiSelect = false;

            this.dataGridViewSepett.MultiSelect = true;

            this.dataGridViewSepett.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSepett.MultiSelect = false;

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
                dataGridViewMenüü.DataSource = ds.Tables["Yiyecekler"];

                
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
                dataGridViewMenüü.DataSource = ds.Tables["İcecekler"];
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
                dataGridViewMenüü.DataSource = ds.Tables["Tatlılar"];
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)//Secılen menuyu menulerden sepete ekleme
        {
            foreach (DataGridViewRow row in dataGridViewMenüü.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; ++i)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                
                this.dataGridViewSepett.Rows.Add(rowData);
                }
            
        }

      
        private void btn_fiyath_Click(object sender, EventArgs e)//Toplam tutarı hesaplama
        {
            int toplam = 0;

            for (int i = 0; i < dataGridViewSepett.Rows.Count; i++)
            {

                toplam += Convert.ToInt32(dataGridViewSepett.Rows[i].Cells[2].Value);
            }
            textBoxTutar.Text = toplam.ToString();



        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            YöneticiGirisi frm = new YöneticiGirisi();
            frm.Show();
        }

        public void gosterY()//masa2 ın sepettekılerı sqldekı sıparıs 2 tablosuna aktarma
        {
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Select * form siparis2", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM siparis2", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "siparis2");
            

            dataGridViewSepett.DataSource = ds.Tables["siparis2"];
            conn.Close();


        }


        private void btn_sipars_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow satirr in dataGridViewMenüü.SelectedRows)//sıparıs ver butonu ıle secılen menulerı sıparıs2 menusune aktarma
            {

                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insert into siparis2 (isim,Fiyat) values (@isim,@Fiyat) ", conn);

                cmd.Parameters.AddWithValue("@isim", satirr.Cells["isim"].Value.ToString());
                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                    conn.Close();
                    gosterY();



            }
            foreach (DataGridViewRow satirr in dataGridViewMenüü.SelectedRows)//sıparıslerın toplam tutarını masa2kasa tablosuna aktarma
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into masa2kasa (Fiyat) values (@Fiyat) ", conn);


                cmd.Parameters.AddWithValue("@Fiyat", satirr.Cells["Fiyat"].Value.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
                gosterY();

            }

            MessageBox.Show("Siparişiniz Alınmıştır.Siparişler bölümünden bakabilirsiniz.");
        }

        private void dataGridViewMenüü_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
