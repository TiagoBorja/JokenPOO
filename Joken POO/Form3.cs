using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joken_POO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
        }

 


        private void pedraBox1_Click_1(object sender, EventArgs e)
        {
            papelBox.Visible = false;
            tesouraBox.Visible = false  ;

            ganhaBox.Image = imageList1.Images[2];
            empateBox.Image = imageList1.Images[0];
            perdeBox.Image = imageList1.Images[1];

            button1.Enabled = true;
            button1.Visible = true;
        }

        private void tesouraBox_Click_1(object sender, EventArgs e)
        {
            papelBox.Visible = false;
            pedraBox1.Visible = false;


            ganhaBox.Image = imageList1.Images[1];
            empateBox.Image = imageList1.Images[2];
            perdeBox.Image = imageList1.Images[0];

            button1.Enabled = true;
            button1.Visible = true;
        }

        private void papelBox_Click_1(object sender, EventArgs e)
        {
            pedraBox1.Visible = false;
            tesouraBox.Visible = false;


            ganhaBox.Image = imageList1.Images[0];
            empateBox.Image = imageList1.Images[1];
            perdeBox.Image = imageList1.Images[2];

            button1.Enabled = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
