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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kullanici = new kullanici();
            kullanici.mail = textBox1.Text;
            kullanici.sifre = textBox2.Text;
            kullanici.durum = true;
            c.kullanici.Add(kullanici);
            c.SaveChanges();
            MessageBox.Show("Kullanıcı Eklendi");
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kullaniciid= comboBox1.SelectedValue;
            var kullanici = c.kullanici.Find(kullaniciid);
            kullanici.sifre = textBox3.Text;
            kullanici.durum = true;
            c.SaveChanges();
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kullaniciid = comboBox2.SelectedValue;
            var kullanici = c.kullanici.Find(kullaniciid);
            kullanici.durum = false;
            c.SaveChanges();
            update();
        }
        private void update()
        {
            var kullanici = c.kullanici.ToList();
            var kullaniciformatted = kullanici.Select(x => new
            {
                x.kullaniciID,
                x.mail,
                x.sifre,
                x.durum,
            }).ToList();
           
            dataGridView1.DataSource = kullaniciformatted;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Mail";
            dataGridView1.Columns[2].HeaderText = "Şifre";
            dataGridView1.Columns[3].HeaderText = "Durum";
            comboBox1.DataSource = kullaniciformatted;
            comboBox1.DisplayMember = "mail";
            comboBox1.ValueMember = "kullaniciID";
            comboBox2.DataSource = kullaniciformatted;
            comboBox2.DisplayMember = "mail";
            comboBox2.ValueMember = "kullaniciID";
        }
    }
}
