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
    public partial class frmEmpleados : Form
    {
        clsGlobalexamen Global = new clsGlobalexamen();
        clsControladorexamen controlador = new clsControladorexamen();
        public frmEmpleados(string text)
        {
            InitializeComponent();
        }

           

        private void txtpuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarGlobal();
            guardarcita();
        }
        private void guardarcita()
        {
            controlador.funcInsertarCita();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtpuesto.Text = "";

        }
        private void GuardarGlobal()
        {
            clsGlobalexamen Global = new clsGlobalexamen();
            Global.codigog = textBox3.Text;
            Global.nombreg = textBox2.Text;
            Global.estatusg = textBox1.Text;


        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 301;
            navegador1.tbl = "puesto";
            navegador1.campoEstado = "estatus_puesto";

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
            navegador1.DatosActualizar = dataGridView1;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            
        }

        private void dvg_puesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarGlobal3();
            guardarcita3();
        }
        private void guardarcita3()
        {
            controlador.funcModiCita();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtpuesto.Text = "";

        }
        private void GuardarGlobal3()
        {
            clsGlobalexamen Global = new clsGlobalexamen();
            Global.codigog = textBox3.Text;
            Global.nombreg = textBox2.Text;
            Global.estatusg = textBox1.Text;


        }
    }
}
