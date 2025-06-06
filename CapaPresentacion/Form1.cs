using CapaDatos;
using System.Data;
using Mensajeria;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Evento para cargar el formulario
        }

        private void TXTdestinatario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTcontenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBOtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNenviarguardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos antes de enviar el mensaje
            if (string.IsNullOrWhiteSpace(TXTdestinatario.Text))
            {
                MessageBox.Show("El campo 'Destinatario' está vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTcontenido.Text))
            {
                MessageBox.Show("El campo 'Contenido' está vacío.");
                return;
            }

            if (CBOtipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un 'Tipo de Mensaje'.");
                return;
            }


            Mensaje mensaje;
            string Tipo = CBOtipo.SelectedItem.ToString();

            // Verificar el tipo de mensaje seleccionado y crear la instancia correspondiente
            if (Tipo == "Email")
            {
                mensaje = new Email();
            }
            else if (Tipo == "Whatsapp")
            {
                mensaje = new Whatsapp();
            }
            else if (Tipo == "Sms")
            {
                mensaje = new Sms();
            }
            else
            {
                MessageBox.Show("Tipo de mensaje no válido.");
                return;
            }
            // Asignar propiedades al mensaje
            mensaje.Contenido = TXTcontenido.Text;
            mensaje.Destinatario = TXTdestinatario.Text;

            // Enviar el mensaje
            mensaje.Enviar();

            // Guardar el mensaje en la base de datos
            MensajeRepositorio repo = new MensajeRepositorio();
            repo.Guardar(mensaje);

            MessageBox.Show("Mensaje enviado y guardado con éxito.");

        }


        private void BTNcargarMensajes_Click(object sender, EventArgs e)
        {
            CargarMensajes(); // Carga los mensajes desde la base de datos al DataGridView
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Limpia los campos del formulario


        }

        // Evento que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Evita duplicar los elementos del ComboBox si ya se han agregado
            if (CBOtipo.Items.Count == 0)
            {
                CBOtipo.Items.AddRange(new string[] { "Email", "Whatsapp", "Sms" });
            }
        }

        private void LimpiarCampos()
        {
            // Limpia los campos del formulario
            TXTdestinatario.Clear();
            TXTcontenido.Clear();
            CBOtipo.SelectedIndex = -1;
            CBOtipo.Text = string.Empty; // Limpia cualquier texto residual
        }

        // Método para cargar los mensajes desde la base de datos al DataGridView
        private void CargarMensajes()
        {
            Mensajeriaconexion data = new Mensajeriaconexion(); // Clase que contiene la conexión
            using (SqlConnection conn = new SqlConnection(data.Conexion))
            {
                try
                {
                    // Limpiar el DataGridView antes de cargar nuevos datos
                    dtgvMensajes.DataSource = null;
                    dtgvMensajes.Rows.Clear();

                    // Abrir la conexión a la base de datos
                    SqlDataAdapter adaptador = new SqlDataAdapter("SELECT TOP 1 * FROM Mensaje ORDER BY Id DESC", conn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dtgvMensajes.DataSource = dt;

                }

                // Capturar cualquier excepción que ocurra al cargar los mensajes
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los mensajes: " + ex.Message); // Muestra un mensaje de error si ocurre una excepción
                }
            }
        }

       
    }
}
