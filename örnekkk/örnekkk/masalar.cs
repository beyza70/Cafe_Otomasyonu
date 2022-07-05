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
    public partial class masalar : Form
    {
        public masalar()
        {
            InitializeComponent();
        }


        private void masa1_Click(object sender, EventArgs e)//masa1 e gıder
        {
            masa1 frm = new masa1();
            frm.Show();
        }

        private void masa2_Click(object sender, EventArgs e)//masa 2 ye gider
        {
            masa2 frm = new masa2();
            frm.Show();
        }

        private void masa3_Click(object sender, EventArgs e)//masa 3 e gier
        {
            masa3 frm = new masa3();
            frm.Show();
        }
       

       
    }
}
