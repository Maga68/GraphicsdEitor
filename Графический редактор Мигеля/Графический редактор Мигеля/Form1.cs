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
    public partial class Fr1 : Form
    {
        public Fr1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.OrangeRed;
        }

       

        

        private void label1_Click(object sender, EventArgs e)
        {
            figure h = new figure();
            h.Show();
            this.Hide();
        }

        private void Fr1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Mouse h = new Mouse();
            h.Show();
            this.Hide();
        }

        

        
    }
}
