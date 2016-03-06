﻿using Ex_Prima_Resources_Map.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_Prima_Resources_Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TopMost = true;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs x)
        {
            this.Opacity = (double)(numericUpDown1.Value) / 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                if (numericUpDown2.Text != "" && numericUpDown2.Text != "")
                {
                    this.Width = Convert.ToInt16((582 * numericUpDown2.Value) / 97);
                    this.Height = Convert.ToInt16((418 * numericUpDown2.Value) / 97 + 32);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Goblu_ExPrima_wo_background;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Pilka_ExPrima_wo_background;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.ResExPrima_wo_background;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Cobal_ExPrima_wo_background;
        }
    }
}
