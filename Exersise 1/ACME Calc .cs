﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersise_1
{
    public partial class ACME_Calc : Form
    {
        public ACME_Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{textBox1.Text} + {textBox2.Text} = {int.Parse(textBox1.Text) + int.Parse(textBox2.Text)}");
        }
    }
}
