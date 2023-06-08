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
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var ogretmen = new ogretmen();
            ogretmen.adi = textBox1.Text;
            ogretmen.soyadi = textBox2.Text;
            ogretmen.tcno = textBox3.Text;
            ogretmen.adres = textBox4.Text;
            ogretmen.dogumtarihi = dateTimePicker1.Value;
            ogretmen.mail = textBox5.Text;
            ogretmen.tel = textBox6.Text;
            if (radioButton1.Checked)
            {
                ogretmen.cinsiyet = false;
            }
            if (radioButton2.Checked) 
            {
                ogretmen.cinsiyet = true;
            }
            ogretmen.maas = textBox7.Text;
            c.ogretmen.Add(ogretmen);
            c.SaveChanges();
            MessageBox.Show("Öğretmen Eklendi");

        }
    }
}
