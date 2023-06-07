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
    public partial class OgrenciEkle : Form
    {
        kresEntities c = new kresEntities();

        public OgrenciEkle()
        {
            InitializeComponent();
            getveli();
        }
        private void getveli()
        {
            var veliler = c.veli.ToList();
            comboBox1.DataSource = veliler;
            comboBox1.DisplayMember = "tcno";
            comboBox1.ValueMember = "veliID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentgender = false;
            if (radioButton1.Checked)
            {
                studentgender=false;
            }
            if (radioButton2.Checked)
            {
                studentgender = true;
            }
            
            var student = c.ogrenci.Create();
            student.adi = textBox1.Text;
            student.soyadi = textBox2.Text;
            student.tcno =Convert.ToInt32(textBox3.Text);
            student.ogrencino = Convert.ToInt32(textBox4.Text);
            student.dogumtarihi = dateTimePicker1.Value;
            student.cinsiyet = studentgender;
            c.ogrenci.Add(student);
            c.SaveChanges();
            var veli = c.ogrenciveli.Create();
            veli.ogrenciID = student.ogrenciID;
            veli.veliID = Convert.ToInt32(comboBox1.SelectedValue);
            c.ogrenciveli.Add(veli);

            c.SaveChanges();

            MessageBox.Show("Öğrenci Eklendi");

        }
    }
}
