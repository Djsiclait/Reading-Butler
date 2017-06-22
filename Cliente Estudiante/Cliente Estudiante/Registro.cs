using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Estudiante
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Login.Instance.Show();
            base.OnClosing(e);
        }

        private void btn_aceptar_cliente_estudiante_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtbox_username_cliente_estudiante.Text+" "+txtbox_name_cliente_estudiante.Text
                + " " + txtbox_apellido_cliente_estudiante.Text + " " + txtbox_contrasena_cliente_estudiante.Text
                + " " + txtbox_confirmarcontrasena_cliente_estudiante.Text + " " + txtbox_email_cliente_estudiante.Text
                + " " + dtPckNacimiento.Text);

            try {
                // TODO: Agregar validacion de datos
                // TODO: Agregar coneccion con servidor
                // TODO: Agregar mensage de confirmacion
                // TODO: Agregar mensage de error

                Login.Instance.Show();
                this.Close();
            }
            catch (Exception exp) {
                // TODO: Agregar notificacion a log de error
            }
        }

        private void btn_cancelar_cliente_estudiante_Click(object sender, EventArgs e)
        {
            Login.Instance.Show();
            this.Close();
        }
    }
}
