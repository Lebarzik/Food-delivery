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
    public partial class Restoran2 : Form
    {
        public Restoran2()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran RestoranForm = new Restoran();
            RestoranForm.Show();
            this.Hide();
        }
    }
}
