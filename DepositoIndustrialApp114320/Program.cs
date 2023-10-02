﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using DepositoIndustrialApp.Servicios;
using DepositoIndustrialApp.Presentacion;

namespace DepositoIndustrialApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal(new FabricaServicioImp()));//de aca se desencadena la fabrica para el resto
        }
    }
}
