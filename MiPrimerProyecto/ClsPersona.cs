using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class ClsPersona
    {

        private String nombre;
        private int cedula;
        private String fecha;

        public ClsPersona(String nombre,int cedula,String fecha)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.fecha = fecha;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }


        public String GetNombre()
        {
            return this.nombre;
        }


        public void SetCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public void SetFecha(String fecha)
        {
            this.fecha = fecha;
        }




        public String GetFecha()
        {
            return this.fecha;
        }



        public int GetCedula()
        {
            return this.cedula;
        }
    }
}
