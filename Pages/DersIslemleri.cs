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
    public partial class DersIslemleri : Form
    {
        public DersIslemleri()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void DersIslemleri_Load(object sender, EventArgs e)
        {
            var dersler = c.ders.ToList();
            comboBox1.DataSource = dersler;
            comboBox1.DisplayMember = "DersAdi";
            comboBox2.DataSource = dersler;
            comboBox2.DisplayMember = "DersAdi";
            dataGridView1.DataSource = dersler;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ders= new ders();
            ders.DersAdi = textBox1.Text;
            c.ders.Add(ders);
            c.SaveChanges();
            MessageBox.Show("Ders Eklendi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ders = c.ders.Where(x => x.DersAdi == comboBox1.Text).FirstOrDefault();
            c.ders.Remove(ders);
            c.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ders = c.ders.Where(x => x.DersAdi == comboBox2.Text).FirstOrDefault();
            ders.DersAdi = textBox2.Text;
            c.SaveChanges();
            MessageBox.Show("Ders Güncellendi");
        }
    }
}
