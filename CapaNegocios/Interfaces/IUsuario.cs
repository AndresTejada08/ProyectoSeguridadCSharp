using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IUsuario
    {
        // Declaración de los métodos de la clase ECliente
        bool Login(EUsuario Usuario);
        DataSet Listar();
        string[] Agregar(EUsuario Usuario);
        string[] Actualizar(EUsuario Usuario);
        string[] Eliminar(int codUsuario);
        DataSet Buscar(string texto, string criterio);
    }
}
