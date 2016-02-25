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
    public partial class CalculadoraSimple : Form
    {
        public CalculadoraSimple()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumero1.Text);
            int num2= Convert.ToInt32(txtNumero2.Text);

            MessageBox.Show((num1 + num2)+"");
        }
    }
}
