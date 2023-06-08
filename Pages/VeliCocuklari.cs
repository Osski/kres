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
    public partial class VeliCocuklari : Form
    {
        public VeliCocuklari()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void VeliCocuklari_Load(object sender, EventArgs e)
        {
            var veli = c.veli.ToList();
            comboBox1.DataSource = veli;
            comboBox1.DisplayMember = "tcno";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var veliselected = (veli)comboBox1.SelectedValue;
            var veli = c.veli.Find(veliselected.veliID);
            var ogrenciler = c.ogrenciveli.Where(x => x.veliID == veli.veliID).ToList();
            var ogrenciwhereinogrenciid = ogrenciler.Select(x => x.ogrenciID).ToList();
            var ogrencilerlist = c.ogrenci.Where(x => ogrenciwhereinogrenciid.Contains(x.ogrenciID)).ToList();
            var ogrenciformatted = ogrencilerlist.Select(x => new
            {
                x.ogrenciID,
                x.adi,
                x.soyadi,
                x.tcno,
                x.ogrencino,
                x.dogumtarihi,
                Cinsiyet = x.cinsiyet == true ? "Kadın" : "Erkek"
            }).ToList();
            dataGridView1.DataSource = ogrenciformatted;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
