﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using baitap1.C_;
namespace baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student sv= new Student();
            sv.password = "what'sup";
            sv.Name = "Thái Vip";
            MessageBox.Show(sv.password);
            
        }
    }
}
