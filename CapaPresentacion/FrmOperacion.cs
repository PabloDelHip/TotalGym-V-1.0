using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using CapaAccesoDatos;
using CapaLogicaNegocios;
using System.IO;
using System.Threading;
using System.Media;
using System.Drawing.Printing;
using System.Collections;

namespace CapaPresentacion
{
    public partial class FrmOperacion : Form
    {
        ClsGeneral cls_generales = new ClsGeneral();
        ClsObservaciones cls_observaciones = new ClsObservaciones();
        ClsSocios cls_socios = new ClsSocios();
        ClsLockers cls_lockers = new ClsLockers();
        ClsMembresias cls_membresias = new ClsMembresias();
        SoundPlayer sonido = new SoundPlayer();
        ClsHdrVentaHist cls_hdr_venta_hist = new ClsHdrVentaHist();
        ClsMovVentasHist cls_mov_ventas_hist = new ClsMovVentasHist();
        ClsProductos cls_productos = new ClsProductos();
        List<datosVenta> lista_datos_venta = new List<datosVenta>();
        DataTable dt;
        double SubtotalAPagar;
        int idSocio;
        int FolioVenta;
        int numero_fila;
        int periodoLocker = 0;
        public FrmOperacion()
        {
            InitializeComponent();
        }

        private Font fuente = new Font("Arial", 12);

        //A continuacion se agregara el siguiente método
        public void Imprimir_Solicitud()
        {

            //Este método contiene dos componentes muy importantes los cuales son:

            //PrintDocument y printDialog estos métodos definen las propiedades de impresión

            //como son: numero de copias, numero de paginas y seleccionar tipo de impresora
            PrintDocument formulario = new PrintDocument();
            formulario.PrintPage += new PrintPageEventHandler(Datos_Cliente);
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = formulario;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                formulario.Print();
            }
        }

        //los datos de nuestros clientes y la posición de los mismos en el documento
        private void Datos_Cliente(object obj, PrintPageEventArgs ev)
        {
            float pos_x = 10;
            float pos_y = 20;
            string Nombre = "Nombre aqui";
            string Direccion = "Direccion aqui";
            string Telefono = "Telefono aqui";

            //Lo que vamos a imprimir
            //Estas 3 prmieras lineas de codigo son las que definen los datos del cliente
            ev.Graphics.DrawString("Nombre: ", fuente, Brushes.Black, pos_x, pos_y, new
            StringFormat());
            ev.Graphics.DrawString("Direccion: ", fuente, Brushes.Black, pos_x, pos_y + 15, new
            StringFormat());
            ev.Graphics.DrawString("Telefono: ", fuente, Brushes.Black, pos_x, pos_y + 30, new
            StringFormat());
            //Estas ultimas 3 lineas de codigo son las que capturamos en nuestro formulario
            ev.Graphics.DrawString(Nombre, fuente, Brushes.Black, pos_x + 65, pos_y, new
            StringFormat());
            ev.Graphics.DrawString(Direccion, fuente, Brushes.Black, pos_x + 75, pos_y + 15, new
            StringFormat());
            ev.Graphics.DrawString(Telefono, fuente, Brushes.Black, pos_x + 80, pos_y + 30, new
            StringFormat());
        }





        private void validarControles(bool bandera)
        {
            TxtNombreSocio.Enabled = bandera;
            TxtDireccion1.Enabled = bandera;
            TxtDireccion2.Enabled = bandera;
            mktCelular.Enabled = bandera;
            TxtEmail.Enabled = bandera;
            RDmasculino.Enabled = bandera;
            RDsexoFem.Enabled = bandera;
            cbbLockers.Enabled = bandera;
            mktFechaNacimiento.Enabled = bandera;
            btnIniciar.Enabled = bandera;

        }

        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            BuscarDispositivos();
            llenarComboMembresias();
            llenarComboProductos();
            cboDispositivos.Visible = false;
            llenarcomboTipoMembresiaLocker();

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        void validarGBX()
        {
            if (TstCmdAgrefarUsr.Text.Equals("Crear socio"))
            {
                bool bandera = true;
                string texto = mktFechaNacimiento.Text.Replace("_", "");
                if (TxtNombreSocio.Text.Equals(""))
                {
                    bandera = false;
                }

                if (TxtDireccion1.Text.Equals("") && TxtDireccion2.Text.Equals(""))
                {
                    bandera = false;
                }

                if (mktCelular.Text.Equals(""))
                {
                    bandera = false;
                }

                if (TxtEmail.Text.Equals(""))
                {
                    bandera = false;
                }

                if (RDmasculino.Checked == false && RDsexoFem.Checked == false)
                {
                    bandera = false;
                }

                if (pbFotoUser.Image == null)
                {
                    bandera = false;
                }

                if (texto.Length < 10)
                {
                    bandera = false;
                }


                if (bandera)
                {
                    gbxMembresia.Enabled = true;
                }
                else
                {
                    gbxMembresia.Enabled = false;
                }
            }


        }

        //*******************************  agregamos los controles para la camara

        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        private void capturarImagen()
        {
            TerminarFuenteDeVideo();
            btnIniciar.Text = "Iniciar";
            cboDispositivos.Enabled = true;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Tomar";
                    cboDispositivos.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                    btnCancelarCamara.Enabled = true;
                }
                else
                    MessageBox.Show("Error: No se encuentra dispositivo.");



            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    capturarImagen();
                }
            }
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbFotoUser.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

        }

        private void cboDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TstCmdAgregarUsr_Click(object sender, EventArgs e)
        {

        }

        //FUNCION PARA CONVERTIR LA IMAGEN A BYTES

        public Byte[] Imagen_A_Bytes(String ruta)

        {

            FileStream foto = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Byte[] arreglo = new Byte[foto.Length];

            BinaryReader reader = new BinaryReader(foto);

            arreglo = reader.ReadBytes(Convert.ToInt32(foto.Length));

            return arreglo;

        }

        //FUNCION PARA CONVERTIR DE BYTES A IMAGEN

        public Image Bytes_A_Imagen(Byte[] ImgBytes)

        {

            Bitmap imagen = null;

            Byte[] bytes = (Byte[])(ImgBytes);

            MemoryStream ms = new MemoryStream(bytes);

            imagen = new Bitmap(ms);

            return imagen;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (TstCmdAgrefarUsr.Text.Equals("Crear socio"))
            {
                TstCmdAgrefarUsr.Text = "Guardar nuevo socio";
                LimpiaFormulario();
                gbxMembresia.Enabled = false;
                validarControles(true);
            }

            else if (TstCmdAgrefarUsr.Text.Equals("Guardar nuevo socio"))
            {

                if (ChkForm_InsOGuardar())
                {
                    ClsSocios Socio = new ClsSocios();
                    string mens = "";
                    TstCmdAgrefarUsr.Text = "Crear socio";

                    // pasamos todos los datos a los parametros de la esctructura para ejecutar el SP AltaSocio
                    Socio.m_Nombre = TxtNombreSocio.Text;
                    //Socio.m_IdSocio =
                    Socio.m_FotoId = "fff";
                    Socio.m_Direccion1 = TxtDireccion1.Text;
                    Socio.m_Direccion2 = TxtDireccion2.Text;
                    Socio.m_Email = TxtEmail.Text;
                    Socio.m_Edad = "0";
                    Socio.m_Telefono = mktCelular.Text;
                    Socio.m_Sexo = RDsexoFem.Checked ? "F" : "M";
                    Socio.m_TipoSocio = txtDiasViajero.Text;

                    Socio.m_Fingerprint = "vacio";
                    //Socio.m_FechaIngreso = DtpFechaIngreso.Value;
                    //Socio.m_Vencimiento = DTPFechaVencHasta.Value;
                    Socio.m_Observacion = "Observaciones";
                    Socio.m_Indicaciones = "Indicaciones";
                    Socio.m_User_modif = "Admin";
                    Socio.m_FechaNacimiento = Convert.ToDateTime(mktFechaNacimiento.Text);
                    // Asignando el valor de la imagen
                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    pbFotoUser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                    //ImgFoto =  ms.GetBuffer();
                    //imagen = Convert.ToByte( ms.GetBuffer());
                    Socio.m_Foto = ms.GetBuffer();

                    //Parametros de salida
                    TxtIdSocio.Text = Socio.InsSocio();
                    idSocio = Convert.ToInt32(TxtIdSocio.Text);
                    // mens = TxtIdSocio.Text;
                    MessageBox.Show("Socio agregado de forma correcta");
                    validarGBX();
                }
            }






        }

        private void cargar_locker(int idSocio)
        {
            cls_lockers.m_idLocker = Convert.ToInt32(cbbLockers.SelectedValue.ToString());
            cls_lockers.m_Descripcion = "";
            cls_lockers.m_Sexo = 'M';
            cls_lockers.m_Status = 'S';
            cls_lockers.m_idSocio = idSocio;
            cls_lockers.numeroDias = periodoLocker;
            cls_lockers.Tipo = 1;
            cls_lockers.modificar_locker();
        }

        private void TSTxtBuscaSocio_Click(object sender, EventArgs e)
        {

        }

        private void buscarSocio()
        {
            ClsSocios Socio = new ClsSocios();
            dt = new DataTable();
            long NoSocio;
            NoSocio = Int64.Parse(TSTxtBuscaSocio.Text);
            Socio.m_IdSocio = NoSocio;
            dt = Socio.RegresaSocio();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow filas in dt.Rows)
                {

                    // indice de columnas 
                    //IdSocio 0
                    TxtIdSocio.Text = filas["IdSocio"].ToString();
                    //[FotoId] 1
                    //[Fingerprint] 2
                    //[Nombre] 3
                    TxtNombreSocio.Text = filas["Nombre"].ToString();
                    //[Direccion1] 4
                    TxtDireccion1.Text = filas["Direccion1"].ToString();
                    //[Direccion2] 5
                    TxtDireccion2.Text = filas["Direccion2"].ToString();
                    //[Email] 6
                    TxtEmail.Text = filas["Email"].ToString();
                    //[Edad] 7 
                    //[Telefono] 8 
                    mktCelular.Text = filas["Telefono"].ToString();
                    //,[Sexo] 9
                    string Sexo;
                    Sexo = filas["Sexo"].ToString();
                    if (Sexo == "F")
                    {
                        RDsexoFem.Checked = true;
                        RDmasculino.Checked = false;
                    }
                    else
                    {
                        RDsexoFem.Checked = false;
                        RDmasculino.Checked = true;
                    }

                    //[TipoSocio] 10
                    //[FechaIngreso] 11
                    //DtpFechaIngreso.Text= filas["FechaIngreso"].ToString();
                    //[Indicaciones] 12
                    //[DiasViajero] 13
                    //[Vencimiento_prev] 14
                    //[Vencimiento] 15

                    //[Observacion] 16
                    //[Fecha_modif] 17
                    //[User_modif] 18
                    //[Foto] 19
                    byte[] imageBuffer = (byte[])filas["Foto"];
                    // Se crea un MemoryStream a partir de ese buffer
                    MemoryStream ms = new MemoryStream(imageBuffer);
                    // Se utiliza el MemoryStream para extraer la imagen
                    //PbFotoSocio.Image = Image.FromStream(ms);
                    pbFotoUser.Image = Image.FromStream(ms);

                    //[fechaNacimiento] 20
                    //DTPFechaNac.Text = filas["fechaNacimiento"].ToString();
                    mktFechaNacimiento.Text = filas["fechaNacimiento"].ToString();
                }
                cls_socios.m_IdSocio = Convert.ToInt32(TxtIdSocio.Text);
                dt = cls_socios.movimientosSocios();
                dataGridView1.DataSource = dt;
                cls_lockers.m_idSocio = Convert.ToInt32(TSTxtBuscaSocio.Text);
                // MessageBox.Show(cls_lockers.m_idSocio.ToString());
                DataTable dtLocker = cls_lockers.buscarLockerSocio();
                foreach (DataRow filas in dtLocker.Rows)
                {
                    DTPLockerVence.Value = Convert.ToDateTime(filas["fechaVencimiento"].ToString());
                }

                dt = cls_socios.buscarSocioDiasViajero();

                if (dt.Rows.Count > 0)
                {
                    txtDiasViajero.Text = dt.Rows[0]["numDiasViajero"].ToString();
                    dtpVencimientoViajero.Value = Convert.ToDateTime(dt.Rows[0]["fechaVencimiento"].ToString());
                }

            }
            else MessageBox.Show("  Socio no encontrado ");
        }

        private void TSTxtBuscaSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                buscarSocio();
                validarControles(false);
                gbxMembresia.Enabled = true;
                TstCmdAgrefarUsr.Text = "Crear socio";
            }
        }
        // First method: Convert Image to byte[] array:
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        // Second method: Convert byte[] array to Image:
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void TsLimpiaForm_Click(object sender, EventArgs e)
        {
            LimpiaFormulario();
            validarGBX();
            validarControles(false);
            TstCmdAgrefarUsr.Text = "Crear socio";
            btnIniciar.Text = "Iniciar";

            btnCancelarCamara.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void LimpiaFormulario()
        {
            DateTime thisDay = DateTime.Today;
            TxtIdSocio.Text = "";
            TxtNombreSocio.Text = "";
            TxtDireccion1.Text = "";
            TxtDireccion2.Text = "";
            TxtEmail.Text = "";
            mktCelular.Text = "";
            //DtpFechaIngreso.Text = "";
            //DTPFechaNac.Value  = thisDay;
            mktFechaNacimiento.Text = "";
            //DtpFechaIngreso.Value = thisDay;
            //PbFotoSocio.Image = null;

            TerminarFuenteDeVideo();

            pbFotoUser.Image = null;
        }

        public bool ChkForm_InsOGuardar()
        {
            Boolean bandera = false;
            // Si el picturebox DEL SOCIO esta vacio,  el chkform marca falso para no continuar
            if (pbFotoUser.Image == null)
            {
                bandera = false;
                MessageBox.Show("     ¡ NO SE HA ASIGNADO UNA FOTO AL SOCIO ! \n  -POR FAVOR TOME LA FOTO ANTES DE CONTINUAR- ");
            }
            else bandera = true;  // HA PASADO EL FILTRO DE LA FOTO



            return bandera;
        }

        private void mktCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mktCelular_Click(object sender, EventArgs e)
        {

            mktCelular.Focus();
        }

        private void RDmasculino_CheckedChanged(object sender, EventArgs e)
        {
            //llama al metodo para llevar el combo de los lockers
            seleccionar_locker(1);
            validarGBX();
        }

        private void RDsexoFem_CheckedChanged(object sender, EventArgs e)
        {
            //llama al metodo para llevar el combo de los lockers
            seleccionar_locker(2);
            validarGBX();
        }

        private void seleccionar_locker(int tipoBusqueda)
        {
            //se le asigna un valor a la variable tipo que se encarga de
            //seleccionar el tipo de busqueda en el SP
            cls_lockers.Tipo = tipoBusqueda;
            //se llama al metodo  donde esta la accion de SP
            DataTable dt = cls_lockers.verLockers();
            //se llena el datasoucer con lo que regreso el SP
            cbbLockers.DataSource = dt;
            //se coloca el indice o option en web
            cbbLockers.ValueMember = "idLocker";
            //se coloca el valor del combo
            cbbLockers.DisplayMember = "Descripcion";
            cbbLockers.Text = "";
        }

        private void llenarComboMembresias()
        {
            //se llama al metodo  donde esta la accion de SP
            cls_membresias.m_idMembresia = 0;
            cls_membresias.Tipo = 1;
            DataTable dt = cls_membresias.seleccionarMembresias();
            //se llena el datasoucer con lo que regreso el SP
            cbbMembresia.DataSource = dt;
            //se coloca el indice o option en web
            cbbMembresia.ValueMember = "idMembresia";
            //se coloca el valor del combo
            cbbMembresia.DisplayMember = "Descripcion";
            cbbMembresia.Text = "";
        }

        private void llenarComboProductos()
        {

            DataTable dt = cls_productos.SeleccionarProductos();
            //se llena el datasoucer con lo que regreso el SP
            cbbProductos.DataSource = dt;
            //se coloca el indice o option en web
            cbbProductos.ValueMember = "idProducto";
            //se coloca el valor del combo
            cbbProductos.DisplayMember = "descripcion";
            cbbProductos.Text = "";
        }

        private void llenarcomboTipoMembresiaLocker()
        {
            cbbMembresiaLockers.Items.Add(" ");
            DataTable dt = cls_lockers.seleccinarMembresiaTipoLockers();
            cbbMembresiaLockers.DataSource = dt;
            cbbMembresiaLockers.ValueMember = "idMembresia";
            //se coloca el valor del combo
            cbbMembresiaLockers.DisplayMember = "Descripcion";
            dataGridView1.DataSource = dt;

        }

        private void cbbLockers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbbLockers.Text.Equals(""))
            {
                //txtnumDias.Enabled = true;
            }
            else
            {
                //txtnumDias.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbbMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buscarProducto(ComboBox combo)
        {
            cls_productos.m_idProducto = Convert.ToInt32(combo.SelectedValue.ToString());
            DataTable dt = cls_productos.buscarProducto();
            datosVenta DatosVenta;
            foreach (DataRow filas in dt.Rows)
            {

                int rowEscribir = Convert.ToInt32(dtgVentas.Rows.Count) - 1;
                //se agrega una nueva fila donde van a ir los datos
                dtgVentas.Rows.Add(1);
                //se agregan los datos
                dtgVentas.Rows[rowEscribir].Cells[0].Value = filas["descripcion"].ToString();
                dtgVentas.Rows[rowEscribir].Cells[1].Value = filas["precio"].ToString();

                DatosVenta = new datosVenta();
                DatosVenta.Item = "Producto " + filas["descripcion"].ToString();
                DatosVenta.Monto = Convert.ToInt32(filas["precio"]);
                DatosVenta.Tipo = 'P';
                DatosVenta.ClaveMembresia = Convert.ToInt32(filas["idProducto"]);
                DatosVenta.DiasViajero = 0;
                DatosVenta.NumDiasViajero = 0;
                DatosVenta.NumeroSumaFechaVencimiento = 0;
                DatosVenta.Prefijo = "";
                lista_datos_venta.Add(DatosVenta);
            }
        }

        private void seleccionarMembresia(ComboBox combo)
        {
            cls_membresias.m_idMembresia = Convert.ToInt32(combo.SelectedValue.ToString());
            cls_membresias.Tipo = 2;
            DataTable dt = cls_membresias.seleccionarMembresias();
            datosVenta DatosVenta;
            foreach (DataRow filas in dt.Rows)
            {

                int rowEscribir = Convert.ToInt32(dtgVentas.Rows.Count) - 1;
                //se agrega una nueva fila donde van a ir los datos
                dtgVentas.Rows.Add(1);
                //se agregan los datos
                dtgVentas.Rows[rowEscribir].Cells[0].Value = filas["Descripcion"].ToString();
                dtgVentas.Rows[rowEscribir].Cells[1].Value = filas["Costo"].ToString();

                DatosVenta = new datosVenta();
                DatosVenta.Item = "Membresia " + filas["Descripcion"].ToString();
                DatosVenta.Monto = Convert.ToInt32(filas["Costo"]);
                DatosVenta.Tipo = Convert.ToChar(filas["Tipo"].ToString());
                DatosVenta.ClaveMembresia = Convert.ToInt32(filas["idMembresia"]);
                DatosVenta.DiasViajero = Convert.ToInt32(filas["Viajero"].ToString());
                DatosVenta.NumDiasViajero = Convert.ToInt32(filas["ConteoViajero"].ToString());
                DatosVenta.NumeroSumaFechaVencimiento = Convert.ToInt32(filas["Periodo"].ToString());
                if (filas["Tipo"].ToString().Equals("L"))
                {
                    periodoLocker = Convert.ToInt32(filas["Periodo"].ToString());
                }
                DatosVenta.Prefijo = filas["prefijo"].ToString();
                lista_datos_venta.Add(DatosVenta);
            }
        }

        private void cbbMembresia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!cbbMembresia.Equals(""))
            {

                seleccionarMembresia(cbbMembresia);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string textoSMS = "";
            if (dtgVentas.Rows.Count <= 1)
            {
                MessageBox.Show("No cuenta con membresias o productos agregados para realizar una venta");
            }
            else if (MessageBox.Show("Cerrar venta?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SubtotalAPagar = 0;
                for (int i = 0; i < lista_datos_venta.Count; i++)
                {
                    SubtotalAPagar += lista_datos_venta[i].Monto;
                }
                FrmPagoVenta frm_pago_venta = new FrmPagoVenta(SubtotalAPagar);
                frm_pago_venta.ShowDialog();
                MessageBox.Show("aqui estamos");
                if (Login.Pago)
                {
                    this.Cursor = Cursors.WaitCursor;
                    double total_a_pagar_Iva = (SubtotalAPagar * 0.16);
                    double total_a_pagar = SubtotalAPagar + total_a_pagar_Iva;
                    cls_hdr_venta_hist.m_IdSocio = Convert.ToInt32(TxtIdSocio.Text);
                    cls_hdr_venta_hist.m_Subtotal = SubtotalAPagar;
                    cls_hdr_venta_hist.m_IVA = total_a_pagar_Iva;
                    cls_hdr_venta_hist.m_Total = total_a_pagar;
                    cls_hdr_venta_hist.m_User_modif = Login.nombre;
                    cls_hdr_venta_hist.m_tipoPago = Login.tipoPago;


                    FolioVenta = Convert.ToInt32(cls_hdr_venta_hist.guardarVenta());
                    //MessageBox.Show("El folio es: " + FolioVenta.ToString());
                    Datos DS = new Datos();
                    verReporte VER;
                    string textoCorreo = "";
                    // bool banderaEnviarSMS = false;

                    textoCorreo += "<style>table, th, td {border: 1px solid black;}</style>";
                    textoCorreo += "<div><b>Clave Socio:" + TxtIdSocio.Text + " </b></div>";
                    textoCorreo += "<table style='border: 1px solid black;'><thead><th style='border: 1px solid black;'> Item </th><th style='border: 1px solid black;'> Monto </th><th style='border: 1px solid black;'>clave</th></thead><tbody>";
                    textoSMS = "clave socio: " + TxtIdSocio.Text + "\n";
                    for (int i = 0; i < lista_datos_venta.Count; i++)
                    {

                        if (!lista_datos_venta[i].Prefijo.Equals(""))
                        {
                            // banderaEnviarSMS = true;
                            textoSMS += "clave: " + lista_datos_venta[i].Item + ": " + lista_datos_venta[i].Prefijo+ TxtIdSocio.Text + "\n\n";
                        }
                        textoCorreo += "<tr>";
                        textoCorreo += "<td style='border: 1px solid black;'>" + lista_datos_venta[i].Item + "</td>";
                        textoCorreo += "<td style='border: 1px solid black;'>$" + lista_datos_venta[i].Monto + "</td>";
                        textoCorreo += "<td style='border: 1px solid black;'>" + lista_datos_venta[i].Prefijo + TxtIdSocio.Text + "</td>";
                        textoCorreo += "</tr>";

                        cls_mov_ventas_hist.m_FolioVenta = FolioVenta;
                        cls_mov_ventas_hist.m_Item = lista_datos_venta[i].Item;
                        cls_mov_ventas_hist.m_Monto = lista_datos_venta[i].Monto;
                        cls_mov_ventas_hist.m_Tipo = lista_datos_venta[i].Tipo;
                        cls_mov_ventas_hist.m_User_modif = Login.nombre;
                        cls_mov_ventas_hist.m_claveTipoMembresia = lista_datos_venta[i].ClaveMembresia;
                        cls_mov_ventas_hist.m_idSocio = Convert.ToInt32(TxtIdSocio.Text);
                        cls_mov_ventas_hist.m_diasViajero = lista_datos_venta[i].DiasViajero;
                        cls_mov_ventas_hist.m_numDiasViajero = lista_datos_venta[i].NumDiasViajero;
                        cls_mov_ventas_hist.m_numeroSumaFechaVencimiento = lista_datos_venta[i].NumeroSumaFechaVencimiento;
                        cls_mov_ventas_hist.guardarMovimientoVenta();
                        DS.Tabla.Rows.Add(Login.nombre, TxtIdSocio.Text, TxtNombreSocio.Text, lista_datos_venta[i].Item, "$" + lista_datos_venta[i].Monto, cls_generales.enletras(SubtotalAPagar.ToString()), FolioVenta.ToString(), "$" + SubtotalAPagar);

                    }
                    textoCorreo += "<tr  style='text-align: right;'><td style='border: 1px solid black;' colspan='3'><b>Total: $" + SubtotalAPagar.ToString() + "</b></td></tr>";
                    textoCorreo += "</tbody>";
                    textoCorreo += "</table>";



                    Login.dineroEntrada += total_a_pagar;

                    SubtotalAPagar = 0;
                    Login.Pago = false;


                    if (!cbbLockers.Text.Equals(""))
                    {
                        cargar_locker(Convert.ToInt32(TxtIdSocio.Text));
                    }


                    // Inicializar el visor de reportes y mandarle la tabla con los datos
                    VER = new verReporte(DS.Tabla,null,null);
                    
                    ArrayList email = new ArrayList();
                    email.Add(TxtEmail.Text);
                    cls_generales.EnviarCorreo(email, textoCorreo, "venta Total Gym", "");
                    //string respuestaSMS = cls_generales.enviarSMS(mktCelular.Text, textoSMS.ToString());

                    //MessageBox.Show(respuestaSMS);
                    LimpiaFormulario();
                    lista_datos_venta.Clear();
                    dtgVentas.Rows.Clear();
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("venta exitosa");
                    
                    //Imprimir_Solicitud();
                }



            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            FuenteDeVideo.Stop();
            pbFotoUser.Image = null;
            btnIniciar.Text = "Iniciar";
            btnCancelarCamara.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Convert.ToInt32(TxtIdSocio.Text).ToString());
            //for (int i = 0; i < lista_datos_venta.Count; i++)
            //{
            //    MessageBox.Show(lista_datos_venta[i].Item);
            //}

            //MessageBox.Show(dtgVentas.Rows.Count.ToString());
        }

        private void TtsGuardaSocio_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreSocio_TextChanged(object sender, EventArgs e)
        {
            validarGBX();
        }

        private void TxtDireccion1_TextChanged(object sender, EventArgs e)
        {
            validarGBX();
        }

        private void TxtDireccion2_TextChanged(object sender, EventArgs e)
        {
            validarGBX();
        }

        private void mktCelular_TextChanged(object sender, EventArgs e)
        {
            validarGBX();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            validarGBX();
        }

        private void mktFechaNacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mktFechaNacimiento.ValidatingType = typeof(System.DateTime);
            //MessageBox.Show(mktFechaNacimiento.ValidatingType.ToString());

        }

        private void mktFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            validarGBX();

            if (mktFechaNacimiento.Text.Length == 10)
            {
                String value = mktFechaNacimiento.Text;
                String[] substrings = value.Split('/');
                int año = Convert.ToInt32(substrings[2]);
                int mes = Convert.ToInt32(substrings[1]);
                int dia = Convert.ToInt32(substrings[0]);
                DateTime nacimiento = new DateTime(año, mes, dia); //Fecha de nacimiento
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                txtEdad.Text = edad.ToString();
            }
            else
            {
                txtEdad.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dtgVentas.Rows.RemoveAt(numero_fila);
                lista_datos_venta.RemoveAt(numero_fila);
                for (int i = 0; i < lista_datos_venta.Count; i++)
                {
                    MessageBox.Show(lista_datos_venta[i].Item.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Favor de seleccinar una fila");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            numero_fila = dtgVentas.CurrentRow.Index;

        }

        private void crToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            LimpiaFormulario();
        }

        private void dtgVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double monto = Convert.ToDouble(dtgVentas.Rows[e.RowIndex].Cells["Monto"].Value.ToString());
            string concepto = dtgVentas.Rows[e.RowIndex].Cells["Concepto"].Value.ToString();
            numero_fila = dtgVentas.CurrentRow.Index;

            FrmDescuento frm_descuento = new FrmDescuento(concepto, monto);
            frm_descuento.ShowDialog();
            if(Login.cantidadDescuento!=0)
            {
                lista_datos_venta[numero_fila].Monto = Login.cantidadDescuento;
                dtgVentas.Rows[e.RowIndex].Cells["Monto"].Value = Login.cantidadDescuento;
            }
            
        }

        private void dtgVentas_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void cbbMembresiaLockers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbMembresiaLockers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            seleccionarMembresia(cbbMembresiaLockers);
            DTPLockerVence.Value = DateTime.Today;
            DTPLockerVence.Value = dtpVencimientoViajero.Value.AddDays(periodoLocker);

            // MessageBox.Show(cbbMembresiaLockers.SelectedValue.ToString());
            // periodoLocker =  Convert.ToInt32(cbbMembresiaLockers.SelectedValue.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void mktFechaNacimiento_Click(object sender, EventArgs e)
        {
            mktFechaNacimiento.Focus();
        }

        private void txtBuscarPorNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                FrmBuscarSocioNombre frm_buscar_socio_por_nombre = new FrmBuscarSocioNombre(txtBuscarPorNombre.Text);
                frm_buscar_socio_por_nombre.ShowDialog();
                if (Login.idSocio != 0)
                {
                    TSTxtBuscaSocio.Text = Login.idSocio.ToString();
                    buscarSocio();
                    validarControles(false);
                    gbxMembresia.Enabled = true;
                    TstCmdAgrefarUsr.Text = "Crear socio"; 
                }

            }
        }

        private void cbbProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            buscarProducto(cbbProductos);
        }
    }

    class datosVenta
    {
        string item;
        char tipo;
        double monto;
        int claveMembresia;
        int diasViajero;
        int numDiasViajero;
        int numeroSumaFechaVencimiento;
        string prefijo;
        public string Item { get => item; set => item = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public double Monto { get => monto; set => monto = value; }
        public int ClaveMembresia { get => claveMembresia; set => claveMembresia = value; }
        public int DiasViajero { get => diasViajero; set => diasViajero = value; }
        public int NumDiasViajero { get => numDiasViajero; set => numDiasViajero = value; }
        public int NumeroSumaFechaVencimiento { get => numeroSumaFechaVencimiento; set => numeroSumaFechaVencimiento = value; }
        public string Prefijo { get => prefijo; set => prefijo = value; }
    }
}
