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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUserScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.modifUserScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.modifEmpleScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmpleScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.configScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.barMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 5);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.configScreen});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.barMenu.Size = new System.Drawing.Size(1264, 32);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUserScreen,
            this.modifUserScreen,
            this.deleteUserScreen});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.toolStripMenuItem1.Text = "ABM Usuarios";
            // 
            // altaUserScreen
            // 
            this.altaUserScreen.Name = "altaUserScreen";
            this.altaUserScreen.Size = new System.Drawing.Size(241, 22);
            this.altaUserScreen.Text = "Alta de Usuario";
            this.altaUserScreen.Click += new System.EventHandler(this.altaUserScreen_Click);
            // 
            // modifUserScreen
            // 
            this.modifUserScreen.Name = "modifUserScreen";
            this.modifUserScreen.Size = new System.Drawing.Size(241, 22);
            this.modifUserScreen.Text = "Modificaciones de Usuario";
            this.modifUserScreen.Click += new System.EventHandler(this.modifUserScreen_Click);
            // 
            // deleteUserScreen
            // 
            this.deleteUserScreen.Name = "deleteUserScreen";
            this.deleteUserScreen.Size = new System.Drawing.Size(241, 22);
            this.deleteUserScreen.Text = "Eliminacion de Usuario";
            this.deleteUserScreen.Click += new System.EventHandler(this.deleteUserScreen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpleScreen,
            this.modifEmpleScreen,
            this.deleteEmpleScreen});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 20);
            this.toolStripMenuItem2.Text = "ABM Empleados";
            // 
            // altaEmpleScreen
            // 
            this.altaEmpleScreen.Name = "altaEmpleScreen";
            this.altaEmpleScreen.Size = new System.Drawing.Size(257, 22);
            this.altaEmpleScreen.Text = "Alta de Empleado";
            // 
            // modifEmpleScreen
            // 
            this.modifEmpleScreen.Name = "modifEmpleScreen";
            this.modifEmpleScreen.Size = new System.Drawing.Size(257, 22);
            this.modifEmpleScreen.Text = "Modificaciones de Empleado";
            // 
            // deleteEmpleScreen
            // 
            this.deleteEmpleScreen.Name = "deleteEmpleScreen";
            this.deleteEmpleScreen.Size = new System.Drawing.Size(257, 22);
            this.deleteEmpleScreen.Text = "Eliminacion de Empleado";
            // 
            // configScreen
            // 
            this.configScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configScreen.Name = "configScreen";
            this.configScreen.Size = new System.Drawing.Size(122, 20);
            this.configScreen.Text = "Configuraciones";
            this.configScreen.Click += new System.EventHandler(this.configScreen_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::CapaVista.Properties.Resources.mantSoftware;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.barMenu);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configScreen;
        private System.Windows.Forms.ToolStripMenuItem altaUserScreen;
        private System.Windows.Forms.ToolStripMenuItem modifUserScreen;
        private System.Windows.Forms.ToolStripMenuItem deleteUserScreen;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleScreen;
        private System.Windows.Forms.ToolStripMenuItem modifEmpleScreen;
        private System.Windows.Forms.ToolStripMenuItem deleteEmpleScreen;
    }
}