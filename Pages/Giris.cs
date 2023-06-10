using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kres.Models;

namespace kres.Pages
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        kresEntities c = new kresEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var login = c.kullanici.Where(x => x.mail == textBox1.Text && x.sifre == textBox2.Text&&x.durum==true).FirstOrDefault();
            if(login != null) 
            {
                var panel = new Pages.Panel();
                panel.Show();
                this.Hide();

            }
        }
    }
}
