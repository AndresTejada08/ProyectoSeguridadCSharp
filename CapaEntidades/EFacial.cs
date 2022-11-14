using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EFacial
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private string codFacial;
        private byte[] imagen;
        private int codUsuario;

        //Propiedades
        public string CodFacial { get => codFacial; set => codFacial = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
    }
}
