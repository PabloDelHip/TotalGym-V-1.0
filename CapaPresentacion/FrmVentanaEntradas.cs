using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;
using System.IO;
using System.Threading;

namespace CapaPresentacion
{
    public partial class FrmVentanaEntradas : Form
    {
        ClsSocios cls_socios = new ClsSocios();
        ClsRegistroEntradas cls_registroEntradas = new ClsRegistroEntradas();
        ClsLockers cls_lockers = new ClsLockers();

        int numeroLocker;
        public FrmVentanaEntradas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variable que recibe la respuesta del procedimiento almacenado
            //string respuesta;
            
            //cls_socios.m_IdSocio =Convert.ToInt32(textBox1.Text);
            //respuesta = cls_socios.ConsultarSocio();
            //if(respuesta.Equals("1"))
            //{
            //    cls_socios.conectarAlServidor(textBox1.Text);
            //}

            //else
            //{
            //    MessageBox.Show("La es incorrecta");
            //}
        }

        private void FrmVentanaEntradas_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void imprimirDatosSocio(Color color)
        {
            DataTable dt = cls_socios.DatosSocio();

            foreach (DataRow filas in dt.Rows)
            {
                txtNombreSocio.Text = filas["Nombre"].ToString();
                txtFechaVencimiento.Text = filas["Vencimiento"].ToString().Substring(0,10);
                byte[] imageBuffer = (byte[])filas["Foto"];
                // Se crea un MemoryStream a partir de ese buffer
                MemoryStream ms = new MemoryStream(imageBuffer);
                // Se utiliza el MemoryStream para extraer la imagen
                pictureBox2.Image = Image.FromStream(ms);
                txtClaveSocio.Text = "";
             }

            this.BackColor = color;
           
            cls_lockers.m_idSocio = numeroLocker;
           string respuesta = cls_lockers.buscar_lockers_ocupados();
           // MessageBox.Show(respuesta);
            cls_socios.conectarAlServidor(Convert.ToInt32(txtClaveSocio.Text));

        }

        private void limpiarFormulario()
        {
            txtClaveSocio.Text = "";
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string respuesta;

                cls_socios.m_IdSocio = Convert.ToInt32(txtClaveSocio.Text);
                respuesta = cls_socios.ConsultarSocio();
                if (respuesta.Equals("1"))                
                {
                   
                    imprimirDatosSocio(Color.Firebrick);

                }

                else if(respuesta.Equals("2"))
                {
                    this.BackColor = Color.Firebrick;
                    imprimirDatosSocio(Color.Gold);
                }

                else if(respuesta.Equals("3"))
                {
                    
                    imprimirDatosSocio(Color.Firebrick);
                    limpiarFormulario();
                }

                else
                {
                    this.BackColor = Color.Firebrick;
                    limpiarFormulario();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numeroLocker = Convert.ToInt32(txtClaveSocio.Text);
            //se envian los valores a las variables de la clase clsRegistroEntradas
            cls_registroEntradas.m_IdSocio = Convert.ToInt32(txtClaveSocio.Text);
            cls_registroEntradas.m_FechaRegistro = DateTime.Now;
            //Se ejecuta el metodo para la insercion del registro de entrada del usuario
            cls_registroEntradas.guardarRegistro();

            string respuesta;

            cls_socios.m_IdSocio = Convert.ToInt32(txtClaveSocio.Text);
            respuesta = cls_socios.ConsultarSocio();
            if (respuesta.Equals("1"))
            {

                imprimirDatosSocio(Color.Firebrick);

            }

            else if (respuesta.Equals("2"))
            {
                this.BackColor = Color.Firebrick;
                imprimirDatosSocio(Color.Gold);
            }

            else if (respuesta.Equals("3"))
            {

                imprimirDatosSocio(Color.Firebrick);
                limpiarFormulario();
            }

            else
            {
                this.BackColor = Color.Firebrick;
                limpiarFormulario();
            }
        }
    }
}
