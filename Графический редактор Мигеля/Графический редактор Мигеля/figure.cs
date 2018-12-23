using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Графический_редактор_Мигеля
{
    public partial class figure : Form
    {
        public figure()
        {
            InitializeComponent();
        }

        private void figure_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            this.Refresh();
            ColorDialog CD = new ColorDialog();
            CD.ShowDialog();
            Color q = CD.Color;
            Pen p1 = new Pen(q, 4);
            Graphics g = this.pictureBox1.CreateGraphics();
            int i, n;
            bool isInt = Int32.TryParse(Convert.ToString(textBox1.Text), out n);
            if (isInt)
            {
                if (n > 0)
                {
                    PointF[] a = new PointF[n];
                    Random r = new Random();
                    pictureBox1.Refresh();
                    for (i = 0; i < n; i++)
                    {
                        a[i].X = r.Next(0, 958);
                        a[i].Y = r.Next(0, 700);
                    }

                    g.DrawPolygon(p1, a);
                }
                else label2.Text = "Введите число >0";
            }
            else label2.Text = "Не число!";
            {
                
            }
}

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            menu.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            menu.Visible = false;
            

            }
 private void but2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.pictureBox1.CreateGraphics();
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            Color color = dialog.Color;
            Pen pen = new Pen(color, 3);
            int j, d;
            d = Convert.ToInt32(textBox1.Text);
            PointF[] a = new PointF[d];
            Random r = new Random();
            pictureBox1.Refresh();
            for (j = 0; j < d; j++)
            {
                a[j].X = r.Next(0, 958);
                a[j].Y = r.Next(0, 700);
            }
            Brush MBrush = new SolidBrush(color);
            g.FillPolygon(MBrush, a);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Fr1 h = new Fr1();
            h.Show();
            this.Hide();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr1 h = new Fr1();
            h.Show();
            this.Hide();
        }

        private void нарисоватьФигуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mouse h = new Mouse();
            h.Show();
            this.Hide();
        }


        }

    }

