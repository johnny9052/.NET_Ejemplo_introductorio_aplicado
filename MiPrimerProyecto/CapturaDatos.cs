﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class CapturaDatos : Form
    {
        public CapturaDatos()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            MessageBox.Show("Hola "+nombre+", ¿como estas?");
        }
    }
}
