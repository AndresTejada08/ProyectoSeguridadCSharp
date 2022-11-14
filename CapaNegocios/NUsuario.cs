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
    public class NUsuario : Interfaces.IUsuario
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO
        
        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool Login(EUsuario Usuario)
        {
            DataRow fila = datos.TraerDataRow("PA_LoginUsuario", Usuario.Usuario.Trim(), Usuario.Contrasena.Trim());
            
            byte CodError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();

            if (CodError == 0)
                return true;
            else
                return false;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_MostrarUsuario");
        }

        public string[] Agregar(EUsuario Usuario)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarUsuario", Usuario.Nombres.Trim().ToUpper(), Usuario.Apellidos.Trim().ToUpper(), 
                Usuario.Usuario.Trim().ToUpper(), Usuario.Contrasena.Trim(), Usuario.Roll.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Actualizar(EUsuario Usuario)
        {
            DataRow row = datos.TraerDataRow("PA_ActualizarUsuario", Usuario.CodUsuario, Usuario.Nombres.Trim().ToUpper(),
                Usuario.Apellidos.Trim().ToUpper(), Usuario.Usuario.Trim().ToUpper(), Usuario.Contrasena.Trim(), Usuario.Roll.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Eliminar(int codUsuario)
        {
            DataRow row = datos.TraerDataRow("PA_EliminarUsuario", codUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("PA_BuscarUsuario", texto, criterio);
        }
    }
}
