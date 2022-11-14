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
    public partial class FormLogin : Form
    {
        // Llamar al servicio (Aun no hice la referencia del servicio)
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void bttnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            string[] valores = servicio.Login(usuario, contrasena).ToArray();
            if (valores[0] == "0" && valores[1] == "ALUMNO")
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();
            }
            else if (valores[0] == "0" && valores[1] == "DOCENTE")
            {
                MessageBox.Show("UD. ES DOCENTE, NO TIENE ACCESO AL SISTEMA", "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(valores[1], "Sistema de Ventas");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
