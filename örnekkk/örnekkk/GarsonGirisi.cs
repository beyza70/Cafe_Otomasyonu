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
    public partial class GarsonGirisi : Form//garson ıcın gorunen form. Sadece masalar ve siparisşere erısebılır
    {
        
        public GarsonGirisi()
        {
            InitializeComponent();
        }

        private void btn_masalar_Click(object sender, EventArgs e)
        {
            masalar frm = new masalar();//masalar formuna gıt
            frm.Show();
        }

        private void btn_siparisler_Click(object sender, EventArgs e)//siparisler formuna gıt
        {
            siparisler frm = new siparisler();
            frm.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)//Otomasyondan cık.
        {
            Environment.Exit(0);
        }

       
    }
}
