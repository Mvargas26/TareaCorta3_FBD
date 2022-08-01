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
        private string pContraseña; 
        private string pEstado;

        public Usuario() 
        { }

        public Usuario(int pId, string pNombre, string pApellidos, string pUsuario, string pContraseña, string pEstado)
        {
            this.PId = pId;
            this.PNombre = pNombre;
            this.PApellidos = pApellidos;
            this.PUsuario = pUsuario;
            this.PContraseña = pContraseña;
            this.PEstado = pEstado;
        }

        public int PId { get => pId; set => pId = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string PApellidos { get => pApellidos; set => pApellidos = value; }
        public string PUsuario { get => pUsuario; set => pUsuario = value; }
        public string PContraseña { get => pContraseña; set => pContraseña = value; }
        public string PEstado { get => pEstado; set => pEstado = value; }
    }
}
