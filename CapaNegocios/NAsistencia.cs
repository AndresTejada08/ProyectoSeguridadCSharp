using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    class NAsistencia : Interfaces.IAsistencia
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO

        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_MostrarAsistencia");
        }

        public string[] Agregar(EAsistencia Asistencia)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarAsistencia", Asistencia.Fecha, Asistencia.CodUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Actualizar(EAsistencia Asistencia)
        {
            DataRow row = datos.TraerDataRow("PA_ActualizarAsistencia", Asistencia.CodAsistencia.Trim().ToUpper(), Asistencia.Fecha, Asistencia.CodUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Eliminar(string codAsistencia)
        {
            DataRow row = datos.TraerDataRow("PA_EliminarAsistencia", codAsistencia);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("PA_BuscarAsistencia", texto, criterio);
        }
    }
}
