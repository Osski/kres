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
    public partial class SinifIslemleri : Form
    {
        public SinifIslemleri()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sinif =new siniflar();
            sinif.sinifadi = textBox1.Text;
            c.siniflar.Add(sinif);
            c.SaveChanges();
            update();
        }

        private void SinifIslemleri_Load(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            comboBox1.DataSource = c.siniflar.ToList();
            comboBox1.DisplayMember = "sinifadi";
            dataGridView1.DataSource = c.siniflar.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sinif = (siniflar)comboBox1.SelectedValue;
            var sinifselected = c.siniflar.Find(sinif.sinifID);
            c.siniflar.Remove(sinifselected);
            c.SaveChanges();
        }
    }
}
