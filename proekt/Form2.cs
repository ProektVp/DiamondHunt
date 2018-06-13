﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace proekt
{
    public partial class Form2 : Form
    {
        Users korisnici;
        public Form2()
        {
            InitializeComponent();
            korisnici = new Users();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            korisnici.addUser(s);
            DiamondHunt d = new DiamondHunt();
            this.Close();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            korisnici.addUser(s);
            MediumLevel m = new MediumLevel();
            this.Close();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            String s = textBox1.Text;
            korisnici.addUser(s);
            HardLevel h = new HardLevel(textBox1.Text);
            this.Close();
            h.Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            String s = textBox1.Text;
            if (s != "")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Invalid name");
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }
    }
}
