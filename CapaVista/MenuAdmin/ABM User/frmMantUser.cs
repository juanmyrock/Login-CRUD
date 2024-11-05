using System;
using System.Windows.Forms;

namespace CapaVista.MenuAdmin.ABM_User
{
    public partial class frmMantUser : Form
    {
        public frmMantUser()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            //boton para cargar el dataGrid con los usuarios existentes
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //boton para refrescar el dataGrid, actualizarlo
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //boton que deselecciona las filas del dgv y vacia los textbox y pone en Enable=true el groupbox para crear y poner los datos de un nuevo usuario
            //pero este boton tiene que abrir un formulario nieto que seleccionaria de otro dgv los empleados ya existentes. Porque si tiene que existir el empleado antes que el usuario de ese empleado
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //boton para guardar cualquier cambio ejecutado en los textbox hacia el dgv, a su vez debe de tener la validacion de campos llamado desde la capa logica
            //debe de guardar un usuario nuevo o si se modifica alguno que selecciones desde una fila del dgv
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            //cuando este checkbox esta habilitado el groupbox se pone en Enable=true tambien y me permite modificar los datos de algun usuario
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //este boton me permite eliminar el usuario que seleccione de la fila del dgv
        }

        //tengo que crear como veras, validaciones de campos, dime que campos con que txtbox debo de crear. A su vez en algun evento del dgv tengo que poder seleccionar por fila y que me cargue esa info automaticamente en los txtbox

        //private bool ValidarCampos()
        //{
        //    if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
        //        string.IsNullOrWhiteSpace(txtContraseña.Text) ||
        //        string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
        //    {
        //        MessageBox.Show("Todos los campos deben ser completados.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;
        //}

    }
}
