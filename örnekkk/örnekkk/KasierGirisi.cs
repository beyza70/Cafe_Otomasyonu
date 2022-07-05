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
    public partial class KasierGirisi : Form //Kasıyer ıcın gorunen form. Sadece kasa formuna erısebilir.
    {
        public KasierGirisi()
        {
            InitializeComponent();
        }

        private void kasa_btn_Click(object sender, EventArgs e)
        {
            Kasa frm = new Kasa();//Kasaya gıt
            frm.Show();
        }

        private void cikis_btn_Click(object sender, EventArgs e)//Otomasyondan cık.
        {
            Environment.Exit(0);
        }

        
    }
}
