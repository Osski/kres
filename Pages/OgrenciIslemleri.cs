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
    public partial class OgrenciIslemleri : Form
    {
        kresEntities c = new kresEntities();

        public OgrenciIslemleri()
        {
            InitializeComponent();
            loaddatagridview();
        }

        public void loaddatagridview()
        {
            var ogrenciler = c.ogrenci;
            var ogrencilerformatted = ogrenciler.Select(x => new
            {
                x.ogrenciID,
                x.adi,
                x.soyadi,
                x.tcno,
                x.ogrencino,
                x.dogumtarihi,
                Cinsiyet = x.cinsiyet == true ? "Kadın" : "Erkek"
            }).ToList();
            dataGridView1.DataSource = ogrencilerformatted;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentadd= new OgrenciEkle();
            studentadd.Show();
        }

        private void StudentUpdate_Click(object sender, EventArgs e)
        {
            var studentupdate = new OgrenciGuncelle();
            studentupdate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count>0)
            {
                var student = c.ogrenci.Find(Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()));
                student.durumu = false;
                c.SaveChanges();
                MessageBox.Show("Öğrenci Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Öğrenciyi Seçiniz");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
