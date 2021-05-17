using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru = 0, doğru = 0, yanlis = 0;

       
    private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Text = "Sonraki";

            soru++;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;


            if (soru == 1)
            {
                richTextBox1.Text = "1.sorunun cevabı 'A'";
                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";
                label7.Text = "A";
            }
         
            if (soru == 2)
            {
                richTextBox1.Text = "2.sorunun cevabı 'B'";
                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";
                label7.Text = "B";
            }
            

            if (soru == 3)
            {
                richTextBox1.Text = "3.sorunun cevabı 'C'";
                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";
                label7.Text = "C";
            }

            if (soru == 4)
            {
                richTextBox1.Text = "4.sorunun cevabı 'D'";
                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";
                label7.Text = "D";
                btnS.Text = "Bitir";
                
            }

            if (soru == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnS.Enabled = false;
                Application.Exit();
            }
            
        }


        private void btnA_Click(object sender, EventArgs e)
        {
            if (label7.Text == btnA.Text)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                doğru++;
                lblD.Text = Convert.ToString(doğru);
            }
            else
            {
                yanlis++;
                lblY.Text = Convert.ToString(yanlis);
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (label7.Text == btnB.Text)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                doğru++;
                lblD.Text = Convert.ToString(doğru);
            }
            else
            {
                yanlis++;
                lblY.Text = Convert.ToString(yanlis);
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (label7.Text == btnC.Text)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                doğru++;
                lblD.Text = Convert.ToString(doğru);
            }
            else
            {
                yanlis++;
                lblY.Text = Convert.ToString(yanlis);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (label7.Text == btnD.Text)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                doğru++;
                lblD.Text = Convert.ToString(doğru);
            }
            else
            {
                yanlis++;
                lblY.Text = Convert.ToString(yanlis);
            }
        }
    }
}
