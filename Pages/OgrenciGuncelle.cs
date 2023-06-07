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
    public partial class OgrenciGuncelle : Form
    {
        kresEntities c = new kresEntities();
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            var students = c.ogrenci.ToList();
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "ogrencino";
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            var selectedStudentID = (ogrenci)comboBox1.SelectedValue;
            var student = c.ogrenci.Find(selectedStudentID.ogrenciID);
            student.adi = txtadi.Text;
            student.soyadi = txtsoyadi.Text;
            student.tcno = Convert.ToInt32(txttc.Text);
            student.ogrencino = Convert.ToInt32(txtogrencino.Text);
            student.dogumtarihi = datepicker.Value;
            if (rdbtnerk.Checked)
            {
                student.cinsiyet = false;
            }
            if (rdbtnkz.Checked)
            {
                student.cinsiyet = true;
            }
            c.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                var selectedStudentID = (ogrenci)comboBox1.SelectedValue;
                var student = c.ogrenci.Find(selectedStudentID.ogrenciID);

                if (student != null)
                {
                    txtadi.Text = student.adi;
                    txtsoyadi.Text = student.soyadi;
                    txttc.Text = student.tcno.ToString();
                    txtogrencino.Text = student.ogrencino.ToString();
                    datepicker.Value = student.dogumtarihi.Value;

                    if (student.cinsiyet == true)
                    {
                        rdbtnkz.Checked = true;
                    }
                    else
                    {
                        rdbtnerk.Checked = true;
                    }
                }
            }

        }
    }
}
