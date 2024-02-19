using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доставка_еды
{
    public partial class Restoran1_Desert : Form
    {
        public Restoran1_Desert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restoran1 RestoranForm = new Restoran1();
            RestoranForm.Show();
            this.Hide();
        }
    }
}
