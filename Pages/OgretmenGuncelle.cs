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
    public partial class OgretmenGuncelle : Form
    {
        public OgretmenGuncelle()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void OgretmenGuncelle_Load(object sender, EventArgs e)
        {
            var ogretmenler = c.ogretmen;
            comboBox1.DataSource = ogretmenler.ToList();
            comboBox1.DisplayMember = "tcno";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue != null)
            {
                var selectedTeacherID = (ogretmen)comboBox1.SelectedValue;
                var teacher = c.ogretmen.Find(selectedTeacherID.ogretmenID);

                if (teacher != null)
                {
                    textBox1.Text = teacher.adi;
                    textBox2.Text = teacher.soyadi;
                    textBox3.Text = teacher.tcno;
                    textBox4.Text = teacher.adres;
                    textBox5.Text = teacher.mail;
                    textBox6.Text = teacher.tel;
                    textBox7.Text = teacher.maas;
                    dateTimePicker1.Value = teacher.dogumtarihi.Value;
                    if (teacher.cinsiyet == true)
                    {
                        radioButton2.Checked = true;
                    }
                    if (teacher.cinsiyet==false)
                    {
                        radioButton1.Checked = true;

                    }
                   


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedTeacherID = (ogretmen)comboBox1.SelectedValue;
            var teacher = c.ogretmen.Find(selectedTeacherID.ogretmenID);
            teacher.adi = textBox1.Text;
            teacher.soyadi = textBox2.Text;
            teacher.tcno = textBox3.Text;
            teacher.adres = textBox4.Text;
            teacher.mail = textBox5.Text;
            teacher.tel = textBox6.Text;
            teacher.maas = textBox7.Text;
            teacher.dogumtarihi = dateTimePicker1.Value;
            if (radioButton1.Checked)
            {
                teacher.cinsiyet = false;
            }
            if (radioButton2.Checked)
            {
                teacher.cinsiyet = true;
            }
            c.SaveChanges();
        }
    }
}
