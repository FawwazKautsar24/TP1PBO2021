using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // image from: C:\Users\asus\source\repos\TP1\img

        void prosedur()
        {
            Panel panelMed = new Panel();
            Panel panelSmall = new Panel();
            Label baju1 = new Label();
            Label harga1 = new Label();
            Button beli1 = new Button();

            panelMed.BackColor = System.Drawing.Color.Ivory;
            panelMed.Controls.Add(panelSmall2);
            panelMed.Controls.Add(beli1);
            panelMed.Controls.Add(harga1);
            panelMed.Controls.Add(baju1);
            panelMed.Location = new System.Drawing.Point(3, 3);
            panelMed.Name = "panelMed";
            panelMed.Size = new System.Drawing.Size(200, 163);
            panelMed.TabIndex = 0;

            panelSmall.BackgroundImage = global::TP1.Properties.Resources.kaos1;
            panelSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panelSmall.Location = new System.Drawing.Point(59, 15);
            panelSmall.Name = "panelSmall";
            panelSmall.Size = new System.Drawing.Size(112, 106);
            panelSmall.TabIndex = 4;

            baju1.AutoSize = true;
            baju1.Location = new System.Drawing.Point(76, 103);
            baju1.Name = "baju1";
            baju1.Size = new System.Drawing.Size(28, 13);
            baju1.TabIndex = 1;
            baju1.Text = "Baju";

            harga1.AutoSize = true;
            harga1.Location = new System.Drawing.Point(73, 125);
            harga1.Name = "harga1";
            harga1.Size = new System.Drawing.Size(46, 13);
            harga1.TabIndex = 2;
            harga1.Text = "100.000";

            beli1.Location = new System.Drawing.Point(65, 140);
            beli1.Name = "beli1";
            beli1.Size = new System.Drawing.Size(75, 23);
            beli1.TabIndex = 3;
            beli1.Text = "beli";
            beli1.UseVisualStyleBackColor = true;
        }

        void prosedur2()
        {
            Panel panelMed2 = new Panel();
            Panel panelSmall2 = new Panel();
            Label baju2 = new Label();
            Label harga2 = new Label();
            Button beli2 = new Button();

            panelMed2.BackColor = System.Drawing.Color.Cornsilk;
            panelMed2.Controls.Add(panelSmall2);
            panelMed2.Controls.Add(beli1);
            panelMed2.Controls.Add(harga1);
            panelMed2.Controls.Add(baju1);
            panelMed2.Location = new System.Drawing.Point(3, 3);
            panelMed2.Name = "panelMed2";
            panelMed2.Size = new System.Drawing.Size(200, 163);
            panelMed2.TabIndex = 0;

            panelSmall2.BackgroundImage = global::TP1.Properties.Resources.kaos1;
            panelSmall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panelSmall2.Location = new System.Drawing.Point(59, 15);
            panelSmall2.Name = "panelSmall2";
            panelSmall2.Size = new System.Drawing.Size(112, 106);
            panelSmall2.TabIndex = 4;

            baju1.AutoSize = true;
            baju1.Location = new System.Drawing.Point(76, 103);
            baju1.Name = "baju2";
            baju1.Size = new System.Drawing.Size(28, 13);
            baju1.TabIndex = 1;
            baju1.Text = "Baju";

            harga2.AutoSize = true;
            harga2.Location = new System.Drawing.Point(73, 125);
            harga2.Name = "harga2";
            harga2.Size = new System.Drawing.Size(46, 13);
            harga2.TabIndex = 2;
            harga2.Text = "100.000";

            beli2.Location = new System.Drawing.Point(65, 140);
            beli2.Name = "beli2";
            beli2.Size = new System.Drawing.Size(75, 23);
            beli2.TabIndex = 3;
            beli2.Text = "beli";
            beli2.UseVisualStyleBackColor = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void beli1_Click(object sender, EventArgs e)
        {
            Detail1 d1 = new Detail1();
            d1.ShowDialog();
            this.Close();
        }

        private void beli2_Click_1(object sender, EventArgs e)
        {
            Detail2 d2 = new Detail2();
            d2.ShowDialog();
            this.Close();
        }

        private void beli3_Click(object sender, EventArgs e)
        {
            Detail3 d3 = new Detail3();
            d3.ShowDialog();
            this.Close();
        }

        private void beli4_Click(object sender, EventArgs e)
        {
            Detail4 d4 = new Detail4();
            d4.ShowDialog();
            this.Close();
        }

        private void beli5_Click(object sender, EventArgs e)
        {
            Detail5 d5 = new Detail5();
            d5.ShowDialog();
            this.Close();
        }
    }
}
