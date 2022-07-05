using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnekkk
{
    public partial class YöneticiGirisi : Form//Yönetici formudur. Bütün formlara erişebilir
    {
        public YöneticiGirisi()
        {
            InitializeComponent();
        }

        private void masalar_Click(object sender, EventArgs e)//masalra git
        {
            masalar frm = new masalar();
            frm.Show();
        }


        private void siparisler_btn_Click(object sender, EventArgs e)//siparsilere git
        {
            siparisler frm = new siparisler();
            frm.Show();
        }

        private void menü_Click(object sender, EventArgs e)//menüye git
        {
            menüler frm = new menüler();
            frm.Show();
        }

        private void personeller_Click(object sender, EventArgs e)//personellere git
        {
            personeller frm = new personeller();
            frm.Show();
        }

        private void kasa_Click(object sender, EventArgs e)//kasaya gıt
        {
            Kasa frm = new Kasa();
            frm.Show();
        }

        private void cikis_Click(object sender, EventArgs e)//Otomasyondan çık
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
