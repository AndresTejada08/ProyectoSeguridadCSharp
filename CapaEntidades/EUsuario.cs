using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuario
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private int codUsuario;
        private string nombres;
        private string apellidos;
        private string usuario;
        private string contrasena;
        private string roll;

        //Propiedades
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Roll { get => roll; set => roll = value; }
    }
}
