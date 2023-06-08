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
    public partial class VeliYeniEkle : Form
    {
        public VeliYeniEkle()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var veli = new veli();
            veli.adi = textBox1.Text;
            veli.soyadi = textBox2.Text;
            veli.tcno = textBox3.Text;
            veli.tel = textBox4.Text;
            veli.adres = textBox5.Text;
            if (radioButton1.Checked)
            {
                veli.cinsiyet = false;
            }
            if (radioButton2.Checked)
            {
                veli.cinsiyet = true;
            }
            c.veli.Add(veli);
            c.SaveChanges();
            MessageBox.Show("Veli Eklendi");

        }
    }
}
