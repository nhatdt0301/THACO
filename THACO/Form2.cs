﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using THACO.DAL;

namespace THACO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            DateTime  dt = DateTime.Parse("2015-11-1");
            dataGridView1.DataSource = service.GetData(dt);
        }
    }
}
