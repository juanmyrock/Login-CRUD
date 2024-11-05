using CapaLogica.Entidades;
using CapaEntidades;
using CapaComun;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace CapaVista.MenuAdmin.ABM_User
{
    public partial class frmMantEmpleado : Form
    {
        cls_EmpleadoManager empleadoManager = new cls_EmpleadoManager();

        public frmMantEmpleado()
        {
            InitializeComponent();
            LlenarCombos();
            grpBoxDatosEmp.Enabled = false;
        }

        
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            CargarEmpleadosForm();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarEmpleadosForm();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cls_Empleado empleadoSelect = dgvEmpleados.CurrentRow.DataBoundItem as cls_Empleado;

            empleadoSelect.Nombre = txtNombre.Text;
            empleadoSelect.Apellido = txtApellido.Text;
            empleadoSelect.IdSexo = Convert.ToInt32(cmbSexo.SelectedValue);
            empleadoSelect.IdTipoDni = Convert.ToInt32(cmbTipoDNI.SelectedValue);
            empleadoSelect.Dni = txtDNI.Text;
            empleadoSelect.FechaNac = dateNacimiento.Value;
            empleadoSelect.Email = txtEmail.Text;
            empleadoSelect.Telefono = txtCelular.Text;
            empleadoSelect.IdLocalidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
            empleadoSelect.Calle = txtCalle.Text;
            empleadoSelect.NumeroCalle = Convert.ToInt32(txtNumCalle.Text);
            empleadoSelect.IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);
            empleadoSelect.Estado = chkEstado.Checked;

            cls_EmpleadoManager empleadoManager = new cls_EmpleadoManager();
            empleadoManager.ModificarEmpleado(empleadoSelect);

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnGuardar.Visible = false;
            btnNewEmpleado.Visible = true;
        }
        private void btnNewEmpleado_Click(object sender, EventArgs e)
        {
            cls_Empleado empleadoNuevo = new cls_Empleado(
                    txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToInt32(cmbSexo.SelectedValue),
                    Convert.ToInt32(cmbTipoDNI.SelectedValue),
                    txtDNI.Text,
                    dateNacimiento.Value,
                    txtEmail.Text,
                    txtCelular.Text,
                    Convert.ToInt32(cmbLocalidad.SelectedValue),
                    txtCalle.Text,
                    Convert.ToInt32(txtNumCalle.Text),
                    Convert.ToInt32(cmbCargo.SelectedValue),
                    Convert.ToBoolean(chkEstado.Checked)
                );
            cls_EmpleadoManager newEmp = new cls_EmpleadoManager();
            newEmp.AgregarEmpleado(empleadoNuevo);

            btnGuardar.Visible = true;
            btnNewEmpleado.Visible = false;
            CargarEmpleadosForm();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEmpleados.CurrentRow != null)
            {
                cls_Empleado empleadoSelect = dgvEmpleados.CurrentRow.DataBoundItem as cls_Empleado;

                txtNombre.Text = empleadoSelect.Nombre;
                txtApellido.Text = empleadoSelect.Apellido;
                cmbSexo.SelectedValue = empleadoSelect.IdSexo;
                cmbTipoDNI.SelectedValue = empleadoSelect.IdTipoDni;
                txtDNI.Text = empleadoSelect.Dni;
                dateNacimiento.Value = empleadoSelect.FechaNac;
                txtEmail.Text = empleadoSelect.Email;
                txtCelular.Text = empleadoSelect.Telefono;
                cmbLocalidad.SelectedValue = empleadoSelect.IdLocalidad;
                txtCalle.Text = empleadoSelect.Calle;
                txtNumCalle.Text = Convert.ToString(empleadoSelect.NumeroCalle);
                cmbCargo.SelectedValue = empleadoSelect.IdCargo;
                chkEstado.Checked = empleadoSelect.Estado;
            }
        }


        private void CargarEmpleadosForm()
        {
            List<cls_Empleado> empleados = empleadoManager.ObtenerListaEmpleados();
            dgvEmpleados.DataSource = empleados;

        }

        private void LlenarCombos()
        {
            cls_LlenarCombos combos_datos = new cls_LlenarCombos();
            // Llenar ComboBox de Sexos
            DataTable CMBSexo = combos_datos.LlenarCombos("Sexos", "id_sexos", "sexo");
            CompletarCombo(cmbSexo, CMBSexo, "sexo", "id_sexos");

            // Llenar ComboBox de Tipos de DNI
            DataTable CMBTipoDNI = combos_datos.LlenarCombos("TiposDocumentos", "id_tipodni", "tipodni");
            CompletarCombo(cmbTipoDNI, CMBTipoDNI, "tipodni", "id_tipodni");

            // Llenar ComboBox de Localidades
            DataTable CMBLocalidad = combos_datos.LlenarCombos( "Localidades", "id_localidad", "localidad");
            CompletarCombo(cmbLocalidad, CMBLocalidad, "localidad", "id_localidad");

            // Llenar ComboBox de Cargos
            DataTable CMBCargo = combos_datos.LlenarCombos( "Cargos", "id_cargos", "cargos");
            CompletarCombo(cmbCargo, CMBCargo, "cargos", "id_cargos");
        }

        private void CompletarCombo (ComboBox CMB, DataTable datos, string CampoDescrip,string CampoID )  
        {
            CMB.DataSource = datos;
            CMB.DisplayMember = CampoDescrip;
            CMB.ValueMember = CampoID;
            CMB.SelectedIndex = -1;
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditar.Checked)
            {
                grpBoxDatosEmp.Enabled = true;
            }
            else
            {
                grpBoxDatosEmp.Enabled = false;
            }
        }

        private void LimpiarCampos()
        {

            txtNombre.Clear();
            txtApellido.Clear();
            cmbSexo.SelectedIndex = -1;
            cmbTipoDNI.SelectedIndex = -1;
            txtDNI.Clear();
            dateNacimiento.Value = DateTime.Now;
            txtEmail.Clear();
            txtCelular.Clear();
            cmbLocalidad.SelectedIndex = -1;
            txtCalle.Clear();
            txtNumCalle.Clear();
            cmbCargo.SelectedIndex = -1;
            chkEstado.Checked = false;
        }

        
    }
}
