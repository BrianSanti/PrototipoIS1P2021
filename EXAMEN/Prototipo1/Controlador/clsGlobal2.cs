using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class clsGlobal2
    {

        static string codigo_concepto;
        static string nombre_concepto;
        static string efecto_concepto;
        static string estatus_concepto;

        public string codigog2
        {
            get { return codigo_concepto; }
            set { codigo_concepto = value; }
        }
        public string nombreg2
        {
            get { return nombre_concepto; }
            set { nombre_concepto = value; }
        }
        public string efectog
        {
            get { return efecto_concepto; }
            set { efecto_concepto = value; }
        }
        public string estatusg2
        {
            get { return estatus_concepto; }
            set { estatus_concepto = value; }
        }
    }
}
