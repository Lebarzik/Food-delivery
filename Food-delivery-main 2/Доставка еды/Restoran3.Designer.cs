
namespace Доставка_еды
{
    partial class Restoran3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горячиеЗакускиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.холодныеЗакускиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.салатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.горячиеЗакускиToolStripMenuItem,
            this.холодныеЗакускиToolStripMenuItem,
            this.салатыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // горячиеЗакускиToolStripMenuItem
            // 
            this.горячиеЗакускиToolStripMenuItem.Name = "горячиеЗакускиToolStripMenuItem";
            this.горячиеЗакускиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.горячиеЗакускиToolStripMenuItem.Text = "Горячие закуски";
            // 
            // холодныеЗакускиToolStripMenuItem
            // 
            this.холодныеЗакускиToolStripMenuItem.Name = "холодныеЗакускиToolStripMenuItem";
            this.холодныеЗакускиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.холодныеЗакускиToolStripMenuItem.Text = "Холодные закуски";
            // 
            // салатыToolStripMenuItem
            // 
            this.салатыToolStripMenuItem.Name = "салатыToolStripMenuItem";
            this.салатыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.салатыToolStripMenuItem.Text = "Салаты";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 299);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Restoran3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(771, 442);
            this.MinimumSize = new System.Drawing.Size(771, 442);
            this.Name = "Restoran3";
            this.Text = "Restoran3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горячиеЗакускиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem холодныеЗакускиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem салатыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    }
}