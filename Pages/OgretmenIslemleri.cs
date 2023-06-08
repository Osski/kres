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
    public partial class OgretmenIslemleri : Form
    {
        kresEntities c = new kresEntities();
        public OgretmenIslemleri()
        {
            InitializeComponent();
        }

        private void OgretmenIslemleri_Load(object sender, EventArgs e)
        {
            var ogretmenler = c.ogretmen;
            var ogretmenformatted = ogretmenler.Select(x => new
            {
                x.ogretmenID,
                x.adi,
                x.soyadi,
                x.tcno,
                x.adres,
                x.dogumtarihi,
                x.mail,
                x.tel,
                Cinsiyet = x.cinsiyet == true ? "Kadın" : "Erkek",
                x.maas
            });
            dataGridView1.DataSource = ogretmenler.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogretmenekle = new OgretmenEkle();
            ogretmenekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ogretmenguncelle = new OgretmenGuncelle();
            ogretmenguncelle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ogretmensinif = new OgretmenSinif();
            ogretmensinif.Show();
        }
    }
}
