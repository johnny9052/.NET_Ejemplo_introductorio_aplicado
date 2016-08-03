using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class ClsPersona
    {

        public String nombre { get; set; }
        public int cedula { get; set; }
        public String fecha { get; set; }

        public ClsPersona(String nombre, int cedula, String fecha)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.fecha = fecha;
        }

    }
}
