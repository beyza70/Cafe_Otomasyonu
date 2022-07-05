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
    public partial class Giris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Giris()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";// basıldıgında kullanıcı adı yazısının gozukmemesı ıcın
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

       private void Giris_btn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();

            //Sqle baglanma kısmı
            con = new SqlConnection("Data Source=LAPTOP-6R29T36N\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
            cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM cafegiris where kullaniciadi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";//cafe giris tablosundan verileri alıp kutucuklara yerlestırme
            dr = cmd.ExecuteReader();
            if (dr.Read())//sqldekı verileri okuduysa
            {
                if (textBox1.Text == "yönetici")//yönetici girişi yapıldıysa
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    YöneticiGirisi frm = new YöneticiGirisi();
                    frm.Show();
                }
                else if (textBox1.Text == "garson")//garson gırısı yapıldıysa
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    GarsonGirisi frm = new GarsonGirisi();
                    frm.Show();
                }
                else if (textBox1.Text == "kasiyer")//kasıyer gırısı yapıldıyss
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    KasierGirisi frm = new KasierGirisi();
                    frm.Show();
                }

            }
            else//Kutucuklar yanlış ya da bos gırıldıyse
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
     
