using CapaLogica.Entidades;
using System;
using System.Windows.Forms;

namespace CapaVista.MenuAdmin.ABM_User
{
    public partial class frmMantEmpleado : Form
    {
        cls_EmpleadoManager empleadoManager = new cls_EmpleadoManager();

        public frmMantEmpleado()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        //private void CargarEmpleadoEnFormulario(int idEmpleado)
        //{
        //    empleadoManager.ObtenerEmpleadoPorId(idEmpleado);

        //    if (empleadoManager != null)
        //    {
        //        AsignarValoresFormulario(empleadoManager);
        //    }
        //}

        //private void AsignarValoresFormulario()
        //{
        //    empleadoManager.AsignarValoresEmpleado(empleado,
        //txtNombre.Text,
        //txtApellido.Text,
        //Convert.ToInt32(cmbSexo.SelectedValue),
        //Convert.ToInt32(cmbTipoDNI.SelectedValue),
        //txtDNI.Text,
        //dateNacimiento.Value,
        //txtEmail.Text,
        //txtCelular.Text,
        //Convert.ToInt32(cmbLocalidad.SelectedValue),
        //txtCalle.Text,
        //Convert.ToInt32(txtNumCalle.Text),
        //Convert.ToInt32(cmbCargo.SelectedValue),
        //chkEstado.Checked);
        //}


    }
}
