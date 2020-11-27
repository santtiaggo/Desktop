using PdD.DAOs_DataAccessObject;
using PdD.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;
using PdD.FFMPEG;

namespace PdD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
   

            ////Llamar al metodo
            UsuariosDAO.iniciar();
            UsuariosDAO.getInstance();
            UsuariosDAO.usuarioExistente("","");
            FfmpegHandler.enviarcmd("/c");

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());

           

        }
        
    }
}
