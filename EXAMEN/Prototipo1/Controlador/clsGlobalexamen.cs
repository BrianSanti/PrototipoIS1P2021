using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class clsGlobalexamen
    {

        static string codigo_puesto;
        static string nombre_puesto;
        static string estatus_puesto;
   



        public string codigog
        {
            get { return codigo_puesto; }
            set { codigo_puesto = value; }
        }
        public string nombreg
        {
            get { return nombre_puesto; }
            set { nombre_puesto = value; }
        }
        public string estatusg
        {
            get { return estatus_puesto; }
            set { estatus_puesto = value; }
        }


    }
}
