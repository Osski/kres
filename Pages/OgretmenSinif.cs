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
    public partial class OgretmenSinif : Form
    {
        public OgretmenSinif()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void OgretmenSinif_Load(object sender, EventArgs e)
        {
            var ogretmen = c.ogretmen;
            var sinif = c.siniflar;
            comboBox1.DataSource = ogretmen.ToList();
            comboBox1.DisplayMember = "tcno";

            comboBox2.DataSource = sinif.ToList();
            comboBox2.DisplayMember = "sinifadi";
            var ogretmensinif = c.sinifogretmen.Select(x => new
            {
                x.sinifogretmenID,
                x.ogretmen.adi,
                x.ogretmen.soyadi,
                x.siniflar.sinifadi
            }).ToList();
            dataGridView1.DataSource = ogretmensinif;
            comboBox3.DataSource = ogretmensinif;
            comboBox3.DisplayMember = "sinifogretmenID";
            comboBox3.ValueMember = "sinifogretmenID";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedTeacherID = (ogretmen)comboBox1.SelectedValue;
            var selectedClassID = (siniflar)comboBox2.SelectedValue;

            var ogretmensinif = new sinifogretmen();
            ogretmensinif.ogretmenID = selectedTeacherID.ogretmenID;
            ogretmensinif.sinifID = selectedClassID.sinifID;
            c.sinifogretmen.Add(ogretmensinif);
            c.SaveChanges();
            MessageBox.Show("Öğretmen Sınıfa Atandı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedTeacherID = comboBox3.SelectedValue;
            var selected = Convert.ToInt32(selectedTeacherID);
            var ogretmensinif = c.sinifogretmen.Where(x => x.sinifogretmenID == selected).FirstOrDefault();
            c.sinifogretmen.Remove(ogretmensinif);
            c.SaveChanges();
            MessageBox.Show("Öğretmen Sınıftan Çıkartıldı");
        }
    }
}
