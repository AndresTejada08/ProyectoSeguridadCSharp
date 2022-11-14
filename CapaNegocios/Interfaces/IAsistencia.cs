using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IAsistencia
    {
        // Declaración de los métodos de la clase ECliente
        DataSet Listar();
        string[] Agregar(EAsistencia Asistencia);
        string[] Actualizar(EAsistencia Asistencia);
        string[] Eliminar(string codAsistencia);
        DataSet Buscar(string texto, string criterio);
    }
}
