using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        // Llamar al servicio
        private static ServiceReference1.wsColegioSoapClient servicio;

        private void Limpiar()
        {
            txtCodUsuario.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtRoll.Text = "";
        }

        public void ListarUsuarios()
        {
            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.Listar().Tables[0];
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string roll = txtRoll.Text.Trim();

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.Agregar(nombres, apellidos, usuario, contrasena, roll);

            ListarUsuarios();
            Limpiar();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codUsuario = Convert.ToInt32(txtCodUsuario.Text.Trim());

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.Eliminar(codUsuario);

            ListarUsuarios();
            Limpiar();
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codUsuario = Convert.ToInt32(txtCodUsuario.Text.Trim());
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string roll = txtRoll.Text.Trim();

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.Actualizar(codUsuario, nombres, apellidos, usuario, contrasena, roll);

            ListarUsuarios();
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string texto  = txtBuscar.Text.Trim();
            string criterio = cbBuscar.Text;

            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.Buscar(texto, criterio).Tables[0];
        }
    }
}
