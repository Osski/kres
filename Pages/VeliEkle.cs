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
    public partial class VeliEkle : Form
    {
        public VeliEkle()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void VeliEkle_Load(object sender, EventArgs e)
        {
            var veliler = c.veli.ToList();
            dataGridView1.DataSource = veliler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var veliYeniEkle =new VeliYeniEkle();
            veliYeniEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var veliguncelle = new VeliGuncelle();
            veliguncelle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var velinincocuklari = new VeliCocuklari();
            velinincocuklari.Show();
        }
    }
}
