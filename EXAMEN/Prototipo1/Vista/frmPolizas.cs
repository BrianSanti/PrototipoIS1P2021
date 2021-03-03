using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class form2 : Form
    {
        clsGlobal2 Global2 = new clsGlobal2();
        clsControladorexamen controlador = new clsControladorexamen();
        public form2(string text)
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 301;
            navegador1.tbl = "concepto";
            navegador1.campoEstado = "estatus_concepto";

            //se agregan los componentes del formulario a la lista tipo control
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
                    {
                        if (C is TextBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is ComboBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is DateTimePicker)
                        {
                            lista.Add(C);
                        }
                    }
                }
            }

            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dataGridView2;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";

        
    }

        private void button1_Click(object sender, EventArgs e)
        { 
            GuardarGlobal2();
            guardarcita2();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void guardarcita2()
        {
            controlador.funcInsertarPoli();
          

        }
        private void modipoli()
        {
            controlador.funcActualizarPoli();
            

        }



        private void GuardarGlobal2()
        {
            clsGlobal2 Global2 = new clsGlobal2();
            Global2.codigog2 = textBox3.Text;
            Global2.nombreg2 = textBox2.Text;
            Global2.efectog = textBox1.Text;
            Global2.estatusg2 = textBox4.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarGlobal2();
            modipoli();
        }

        private void button3_Click(object sender, EventArgs e)
        {




        }
    }
}
