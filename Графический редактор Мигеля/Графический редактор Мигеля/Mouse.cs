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
    public partial class Mouse : Form
    {
        public Mouse()
        {
            InitializeComponent();
        }
        bool b = false;
        Image a;
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            menu.Visible = true;
         }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            menu.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fr1 h = new Fr1();
            h.Show();
            this.Hide();
        }

        private void Mouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void but1_Click(object sender, EventArgs e)
        {
           Image im;
           this.Refresh();
           im = (Image)Image.FromFile("0.jpg");
           pictureBox6.Image = im;
           pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox6.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Brush green = new SolidBrush(Color.Green);
            Brush black = new SolidBrush(Color.Black);
            Brush yellow = new SolidBrush(Color.Yellow);
            Brush br = new SolidBrush(Color.White);
            RectangleF r1 = new Rectangle(e.X - 10, e.Y - 10, 20, 20);
            RectangleF r2 = new Rectangle(e.X - 25, e.Y - 25, 50, 50);
            if (b)
            {
                if (chB1.Checked)
                {
                    g.FillEllipse(br, r2);
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        g.FillEllipse(red, r1);
                    }
                    if (radioButton2.Checked)
                    {
                        g.FillEllipse(green, r1);
                    }
                    if (radioButton3.Checked)
                    {
                        g.FillEllipse(black, r1);
                    }
                    if (radioButton4.Checked)
                    {
                        g.FillEllipse(yellow, r1);
                    }
                }
            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            b = true;
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            b = false;
        }

        private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            bool с = openFileDialog1.CheckFileExists;
            if (с)
            {
                openFileDialog1.Title = "Вставка рисунка";
                openFileDialog1.Filter = "JPG files(*.JPG)|*.JPG";
                openFileDialog1.ShowDialog();
                var image= openFileDialog1.OpenFile();
                
                    pictureBox6.Image = System.Drawing.Image.FromStream(image);
                a = pictureBox6.Image;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr1 h = new Fr1();
            h.Show();
            this.Hide();
        }

        private void нарисоватьФигуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figure h = new figure();
            h.Show();
            this.Hide();
        }

       
        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox6.Image = a;
        }

        

        private void увеличениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeF s = new SizeF(1.0F, 2.0F);
            pictureBox6.Scale(s);
        }

        private void уменьшениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeF s = new SizeF(1.0F, 0.5F);
            pictureBox6.Scale(s);
        }

       
        }
    }

