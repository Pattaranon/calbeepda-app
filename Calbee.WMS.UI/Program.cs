using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Calbee.Infra.Helper.Message;
using System.Diagnostics;
using Calbee.Infra.Helper.Threading;
using System.IO;

namespace Calbee.WMS.UI
{
    static class Program
    {
        /// <summary>
        /// need to declare this to field scope to prevent GC Collect this while application is running
        /// </summary>
        // private static Calbee.Infra.Helper.Threading.NamedMutex mutexForCheckMultipleApp;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            /*
            bool createdNew = true;
            mutexForCheckMultipleApp = new Calbee.Infra.Helper.Threading.NamedMutex(false, @"Calbee", out createdNew);

            if (createdNew)
            {
                Application.Run(new Authentication.frmLogin());
            }
            else
            {
                MsgBox.DialogWarning("The program is running. Cannot open more than 1 program");
            }
            */

            try
            {
                if (Calbee.Infra.Common.Constants.IConstants.platformWinCE.Equals("Y"))
                {
                    // For Windows CE
                    using (NamedMutex mutex = new NamedMutex(false, "Global\\" + @"\Calbee.WMS.UI\Calbee.WMS.UI"))
                    {
                        if (mutex.WaitOne(0, false))
                        {
                            //not already running
                            Application.Run(new Authentication.frmLogin());
                        }
                        else
                        {
                            // already running
                            MsgBox.DialogWarning("Calbee program is already running.");
                            return;
                        }
                    }
                }
                else
                {
                    // For Windows Runtime
                    Application.Run(new Authentication.frmLogin());
                }
            }
            catch (Exception)
            {
                Application.Run(new Authentication.frmConfigWebService());
            }
        }
    }
}