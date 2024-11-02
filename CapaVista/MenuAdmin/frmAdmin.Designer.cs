namespace CapaVistas.MenuAdmin
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barMenu = new System.Windows.Forms.MenuStrip();
            this.btnMantUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMantEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.barMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 5);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMantUser,
            this.btnMantEmpleado,
            this.btnConfigScreen});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.barMenu.Size = new System.Drawing.Size(1264, 32);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "menuStrip1";
            // 
            // btnMantUser
            // 
            this.btnMantUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMantUser.Name = "btnMantUser";
            this.btnMantUser.Size = new System.Drawing.Size(106, 20);
            this.btnMantUser.Text = "ABM Usuarios";
            this.btnMantUser.Click += new System.EventHandler(this.btnMantUser_Click);
            // 
            // btnMantEmpleado
            // 
            this.btnMantEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMantEmpleado.Name = "btnMantEmpleado";
            this.btnMantEmpleado.Size = new System.Drawing.Size(122, 20);
            this.btnMantEmpleado.Text = "ABM Empleados";
            this.btnMantEmpleado.Click += new System.EventHandler(this.btnMantEmpleado_Click);
            // 
            // btnConfigScreen
            // 
            this.btnConfigScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfigScreen.Name = "btnConfigScreen";
            this.btnConfigScreen.Size = new System.Drawing.Size(122, 20);
            this.btnConfigScreen.Text = "Configuraciones";
            this.btnConfigScreen.Click += new System.EventHandler(this.btnConfigScreen_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.barMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.barMenu;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.Text = "Control de Administradores";
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barMenu;
        private System.Windows.Forms.ToolStripMenuItem btnMantUser;
        private System.Windows.Forms.ToolStripMenuItem btnMantEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnConfigScreen;
    }
}