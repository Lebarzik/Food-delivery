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
using System.Data.SqlClient;

namespace Доставка_еды
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*GraphicsPath path = new GraphicsPath();

            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);

            int diameter = 10 * 2;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            gp.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            gp.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
            gp.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);

            gp.CloseFigure();

            Region region = new Region(gp);
            pictureBox1.Region = region;*/

            Border_Radius(pictureBox1, 10);
            Border_Radius(pictureBox2, 10);
            Border_Radius(pictureBox3, 10);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Restoran RestoranForm = new Restoran();
            RestoranForm.Show();
            this.Hide();
        }
    }
}
