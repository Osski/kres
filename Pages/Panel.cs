using kres.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kres.Pages
{
    public partial class Panel : Form
    {
        kresEntities c = new kresEntities();
        public Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogrenciislemleri= new Pages.OgrenciIslemleri();
            ogrenciislemleri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ogretmenislemleri = new Pages.OgretmenIslemleri();
            ogretmenislemleri.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var veliislemleri = new Pages.VeliEkle();
            veliislemleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sinif = new Pages.SinifIslemleri();
            sinif.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var DersIslemleri = new Pages.DersIslemleri();
            DersIslemleri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dersprogrami = new Pages.DersProgrami();
            dersprogrami.Show();
        }

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogresult = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ayarlar = new Pages.Ayarlar();
            ayarlar.Show();
        }
    }
}
