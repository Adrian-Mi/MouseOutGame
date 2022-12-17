using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGame
{
    public partial class Form1 : Form
    {
        bool flag ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (flag==false )
                MessageBox.Show("you lose!!!");
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            flag = false;
            MessageBox.Show("you lose!");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (flag == false)
                MessageBox.Show("you lose!!!");
          
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (flag == false)
                MessageBox.Show("you lose!!!");
          
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (flag == false)
                MessageBox.Show("you lose!!!");
           
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            if (flag == false)
                MessageBox.Show("you lose!!!");
           
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            if (flag == false)
                MessageBox.Show("you lose!!!");
            
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("you win!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = true;
        }
    }
}
