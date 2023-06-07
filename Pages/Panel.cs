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
    public partial class Panel : Form
    {
        kresEntities c = new kresEntities();
        public Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogrenciislemleri= new Pages.OgrenciIslemleri();
            ogrenciislemleri.Show();
        }
    }
}
