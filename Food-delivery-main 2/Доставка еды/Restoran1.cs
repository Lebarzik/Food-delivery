using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доставка_еды
{
    public partial class Restoran1 : Form
    {
        public Restoran1()
        {
            InitializeComponent();
        }

        private void Border_Radius(PictureBox img, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            gp.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            gp.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
            gp.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);

            gp.CloseFigure();

            Region region = new Region(gp);
            img.Region = region;
        }

        private void Restoran1_Load(object sender, EventArgs e)
        {

        }

        private void закускиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran1__Zakuski Restoran1_ZakuskiForm = new Restoran1__Zakuski();
            Restoran1_ZakuskiForm.Show();
            this.Hide();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran RestoranForm = new Restoran();
            RestoranForm.Show();
            this.Hide();
        }

        private void десертыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran1_Desert Restoran1_ZakuskiForm = new Restoran1_Desert();
            Restoran1_ZakuskiForm.Show();
            this.Hide();
        }

        private void напиткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran1_Napitki Restoran1_ZakuskiForm = new Restoran1_Napitki();
            Restoran1_ZakuskiForm.Show();
            this.Hide();
        }
    }
}
