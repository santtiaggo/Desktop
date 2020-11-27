
using PdD.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PdD.DAOs_DataAccessObject
{
    class UsuariosDAO
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public static UsuariosDAO instance;

        public static void iniciar() 
        {
            ListaUsuarios.Add(new Usuario("1", "1"));
            ListaUsuarios.Add(new Usuario("hola", "hola"));
            ListaUsuarios.Add(new Usuario("admin", "admin"));
        }

        public static bool usuarioExistente(string username, string password) 
        {
            // Logica de comprobar credenciales:
            //-Devuelvo siempre true.
            //-Tengo usuarios hardcodeados
            //-Abro archivo de texto con usuarios creados y compruebo si el usuario existe.
            //-Me conecto a DB, tiro query preguntando por usuario.

            var objUsuario = ListaUsuarios.Find(x => x.username == username && x.password == password);

            if(objUsuario == null) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public static UsuariosDAO getInstance()
        {
            if (instance == null)
            {
                UsuariosDAO.instance = new UsuariosDAO();
            }
            return instance;
        }
        public List<Usuario> verUsuarios()
        {
            //return personas;
            return ListaUsuarios;
        }
    }
}
