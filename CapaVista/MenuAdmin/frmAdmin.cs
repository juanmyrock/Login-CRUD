using System;
using System.Windows.Forms;
using CapaVista.MenuAdmin.ABM_User;
using CapaVista.MenuAdmin;

namespace CapaVistas.MenuAdmin
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        public void AbrirFrmHijo(Form formHijo)
        {
            // Cierra cualquier formulario hijo abierto previamente
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configura el formulario hijo
            formHijo.MdiParent = this;        // Establece el formulario padre
            formHijo.Dock = DockStyle.Fill;    // Hace que el formulario hijo ocupe todo el área disponible
            formHijo.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario hijo
            formHijo.Show();
        }

        private void altaUserScreen_Click(object sender, EventArgs e)
        {
            frmAltaUser frmAltaUser = new frmAltaUser();
            AbrirFrmHijo(frmAltaUser);
        }

        private void modifUserScreen_Click(object sender, EventArgs e)
        {
            frmModifUser frmModifUser = new frmModifUser();
            AbrirFrmHijo(frmModifUser);
        }

        private void deleteUserScreen_Click(object sender, EventArgs e)
        {
            frmDeleteUser frmDeleteUser = new frmDeleteUser();
            AbrirFrmHijo(frmDeleteUser);
        }

        private void configScreen_Click(object sender, EventArgs e)
        {
            frmConfigLogin frmConfig = new frmConfigLogin();
            AbrirFrmHijo(frmConfig);
        }



        

        
    }
}
