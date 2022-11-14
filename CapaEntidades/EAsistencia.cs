using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EAsistencia
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private string codAsistencia;
        private DateTime fecha;
        private int codUsuario;

        //Propiedades
        public string CodAsistencia { get => codAsistencia; set => codAsistencia = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
    }
}
