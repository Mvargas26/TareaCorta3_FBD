using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Usuario
    {
        private int pId;
        private string pNombre;
        private string pApellidos;
        private string pUsuario;
        private short pEstado;
        private string pContrasena;

        public Usuario() 
        { }

        public Usuario(int pId, string pNombre, string pApellidos, string pUsuario, string pContrasena, short pEstado)
        {
            this.PId = pId;
            this.PNombre = pNombre;
            this.PApellidos = pApellidos;
            this.PUsuario = pUsuario;
            this.PContrasena = pContrasena;
            this.PEstado = pEstado;
        }

        public int PId { get => pId; set => pId = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string PApellidos { get => pApellidos; set => pApellidos = value; }
        public string PUsuario { get => pUsuario; set => pUsuario = value; }
        public string PContrasena { get => pContrasena; set => pContrasena = value; }
        public short PEstado { get => pEstado; set => pEstado = value; }
    }
}
