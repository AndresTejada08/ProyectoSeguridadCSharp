using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IFacial
    {
        // Declaración de los métodos de la clase ECliente
        DataSet Listar();
        string[] Agregar(EFacial Facial);
        string[] Actualizar(EFacial Facial);
        string[] Eliminar(string codFacial);
        DataSet Buscar(string texto, string criterio);
    }
}
