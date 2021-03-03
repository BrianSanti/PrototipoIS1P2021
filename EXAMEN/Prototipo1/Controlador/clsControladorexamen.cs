using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class clsControladorexamen
    {
        clsModeloExamen modelo = new clsModeloExamen();
        clsGlobalexamen glo = new clsGlobalexamen();
        clsGlobal2 glo2 = new clsGlobal2();


        public OdbcDataReader funcInsertarCita()
        {
            string Consulta = "INSERT INTO puesto (codigo_puesto, nombre_puesto, estatus_puesto) VALUES('" + glo.codigog + "','" + glo.nombreg + "'," + glo.estatusg + "); ";
            

            return modelo.funcInsertar(Consulta);
        }
        public OdbcDataReader funcModiCita()
        {
            string Consulta = "UPDATE puesto SET nombre_puesto = '" + glo.nombreg + "', estatus_puesto = '" + glo.estatusg + "' where codigo_puesto = " + glo.codigog + ";";
            return modelo.funcModificar(Consulta);
        }
        public OdbcDataReader funcInsertarPoli()
        {
            string Consulta = "INSERT INTO concepto (codigo_concepto, nombre_concepto,efecto_concepto, estatus_concepto) VALUES ('" + glo2.codigog2 + "','" + glo2.nombreg2 + "','" + glo2.efectog+ "'," + glo2.estatusg2 + "); ";
            

            return modelo.funcInsertar(Consulta);
        }
        public OdbcDataReader funcActualizarPoli()
        {
            string Consulta = "UPDATE concepto SET nombre_concepto = '" + glo2.nombreg2 + "', efecto_concepto = '" + glo2.efectog+ "', estatus_concepto = '" + glo2.efectog + "' where codigo_concepto = " + glo2.codigog2 + ";";
            return modelo.funcModificar(Consulta);
        }

      

    }
}
