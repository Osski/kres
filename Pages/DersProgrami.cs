﻿using kres.Models;
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
    public partial class DersProgrami : Form
    {
        public DersProgrami()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void DersProgrami_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            comboBox1.DataSource = c.ders.ToList();
            comboBox1.DisplayMember = "dersadi";
            comboBox2.DataSource = c.ogretmen.ToList();
            comboBox2.DisplayMember = "tcno";
            comboBox3.DataSource = c.siniflar.ToList();
            comboBox3.DisplayMember = "sinifadi";
            comboBox5.DataSource = c.siniflar.ToList();
            comboBox5.DisplayMember = "sinifadi";
            update();


        }
        private void update()
        {
            var dersprogrami = c.DersProgrami.Select(x => new
            {
                x.DersProgramiID,
                x.siniflar.sinifadi,
                x.ders.DersAdi,
                x.ogretmen.adi,
                x.Gun,
                x.BaslangicSaat,
                x.BitisSaat
            });
            dataGridView1.DataSource = dersprogrami.ToList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var dersprogrami = c.DersProgrami.Find(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                c.DersProgrami.Remove(dersprogrami);
                c.SaveChanges();
                MessageBox.Show("Silme işlemi başarılı");
                update();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var dersprogramiselected = (Models.DersProgrami)comboBox5.SelectedValue;
            //var program = c.DersProgrami.Where(x => x.SinifID == dersprogramiselected.SinifID);
            //dataGridView1.DataSource = program.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dersprogrami = new Models.DersProgrami();
            dersprogrami.DersID = ((Models.ders)comboBox1.SelectedValue).DersID;
            dersprogrami.OgretmenID = ((Models.ogretmen)comboBox2.SelectedValue).ogretmenID;
            dersprogrami.SinifID = ((Models.siniflar)comboBox3.SelectedValue).sinifID;
            dersprogrami.Gun =Convert.ToString(comboBox4.SelectedItem);
            dersprogrami.BaslangicSaat = dateTimePicker2.Value.TimeOfDay;
            dersprogrami.BitisSaat = dateTimePicker3.Value.TimeOfDay;
            c.DersProgrami.Add(dersprogrami);
            c.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
            update();

        }
    }
}
