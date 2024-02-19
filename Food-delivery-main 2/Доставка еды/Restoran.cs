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
    public partial class Restoran : Form
    {
        public Restoran()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Restoran1 Restoran1Form = new Restoran1();
            Restoran1Form.Show();
            this.Hide();
        }

        private void Restoran_Load(object sender, EventArgs e)
        {
            Border_Radius(pictureBox1, 10);
            Border_Radius(pictureBox2, 10);
            Border_Radius(pictureBox3, 10);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restoran2 Restoran2Form = new Restoran2();
            Restoran2Form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Restoran3 Restoran3Form = new Restoran3();
            Restoran3Form.Show();
            this.Hide();
        }
    }
}
