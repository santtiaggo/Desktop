using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD.Modelo
{
    class Usuario
    {
        public string username { get; set; }
        public string password { get; set; }
        public string id { get; set; }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
           
        }
    }
}