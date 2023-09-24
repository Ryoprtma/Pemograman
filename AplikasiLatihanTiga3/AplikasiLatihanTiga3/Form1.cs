using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var Nama = txtNama.Text;
            var Pendidikan =lstPekerjaan.Text;
            var Pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Hallo {0}", Nama);
            txtPesan2.Text = string.Format("Pendidikan Anda {0} Ya?", Pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0}, hebat !!!!", Pekerjaan);
        }
    }
}
