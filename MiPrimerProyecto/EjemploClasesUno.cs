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
    public partial class EjemploClasesUno : Form
    {

        private ClsOperaciones operaciones;
        
        public EjemploClasesUno()
        {
            InitializeComponent();
            operaciones = new ClsOperaciones();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            MessageBox.Show("El resultado es " + operaciones.Sumar(num1, num2));
        }
    }
}
