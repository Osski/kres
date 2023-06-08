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
    public partial class VeliGuncelle : Form
    {
        public VeliGuncelle()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void VeliGuncelle_Load(object sender, EventArgs e)
        {
            var veliler = c.veli.ToList();
            comboBox1.DataSource = veliler;
            comboBox1.DisplayMember = "tcno";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedVeliID = (veli)comboBox1.SelectedValue;
            var veli = c.veli.Find(selectedVeliID.veliID);
            if (veli != null)
            {
                textBox1.Text = veli.adi;
                textBox2.Text = veli.soyadi;
                textBox3.Text = veli.tcno;
                textBox4.Text = veli.tel;
                textBox5.Text = veli.adres;
                if (veli.cinsiyet==true)
                {
                    radioButton2.Checked = true;
                }
                if (veli.cinsiyet==false)
                {
                    radioButton1.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var veliID = (veli)comboBox1.SelectedValue;
            var veli = c.veli.Find(veliID.veliID);
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
            c.SaveChanges();
            MessageBox.Show("Veli Güncellendi");
        }
    }
}
