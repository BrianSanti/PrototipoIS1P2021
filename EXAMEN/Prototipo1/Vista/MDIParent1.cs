using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad.Formularios.Mantenimientos;
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
   
    public partial class MDIParent1 : Form

    { clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();//instancia para los permisos por aplicacion
        clsVistaBitacora bit = new clsVistaBitacora();//instancia para la bitacora.
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = frm.usuario();
           
            }


        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("302", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Mantenimiento Empleados", 302);
                frmEmpleados mantenimientoCentro = new frmEmpleados(txtusuario.Text);
                mantenimientoCentro.MdiParent = this;
                mantenimientoCentro.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar a Mantenimiento Empelados", 302);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmpleados mantenimientoMotivo = new frmEmpleados(txtusuario.Text);
            mantenimientoMotivo.MdiParent = this;
            mantenimientoMotivo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Asignacion de Perfil y Aplicaciones", 6);
                frmAsignacionDeAplicaciones perfil = new frmAsignacionDeAplicaciones();
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar a Asignacion de perfil y aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso A Mantenimiento Usuario", 2);
                frmMantenimientoUsuario mantenimientoUsuario = new frmMantenimientoUsuario(txtusuario.Text);
                mantenimientoUsuario.MdiParent = this;
                mantenimientoUsuario.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de ingresar a Mantenimiento Usuario", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("301", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Mantenimiento Empleados", 301);
                form2 mantenimientoCentro2 = new form2(txtusuario.Text);
                mantenimientoCentro2.MdiParent = this;
                mantenimientoCentro2.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar a Mantenimiento Empelados", 301);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
    }

