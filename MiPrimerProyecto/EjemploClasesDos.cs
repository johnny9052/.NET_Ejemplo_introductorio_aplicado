using System;
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
    public partial class EjemploClasesDos : Form
    {
        public EjemploClasesDos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            String fecha = txtFecha.Value.ToShortDateString(); ;

            ClsPersona persona = new ClsPersona(nombre,cedula,fecha);

            MessageBox.Show("Nombre: " + persona.nombre + "\n" +
                            "Cedula: " + persona.cedula + "\n" +
                            "Fecha: " + persona.fecha + "\n");
        }
    }
}
