using CapaEntidades;
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
    class NFacial : Interfaces.IFacial
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO

        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_MostrarFacial");
        }

        public string[] Agregar(EFacial Facial)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarFacial", Facial.Imagen, Facial.CodUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Actualizar(EFacial Facial)
        {
            DataRow row = datos.TraerDataRow("PA_ActualizarFacial", Facial.CodFacial.Trim().ToUpper(), Facial.Imagen, Facial.CodUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Eliminar(string codFacial)
        {
            DataRow row = datos.TraerDataRow("PA_EliminarFacial", codFacial);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("PA_BuscarFacial", texto, criterio);
        }

        
    }
}
