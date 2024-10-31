﻿using CapaVistas.MenuAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CapaVista.frmLogin frm = new CapaVista.frmLogin();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                Application.Run(new frmAdmin());

        }
    }
}
