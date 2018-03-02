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

namespace CapaPresentacion
{
    public partial class FrmCancelarTicket : Form
    {
        ClsHdrVentaHist cls_hdr_venta_hist = new ClsHdrVentaHist();
        public FrmCancelarTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_hdr_venta_hist.m_FolioVenta = Convert.ToInt32(txtNumTicket.Text);
           string respuesta =  cls_hdr_venta_hist.cancelarTicket();
            MessageBox.Show(respuesta);

            if(respuesta.Equals("Ticket cancelado de forma correcta"))
            {
                this.Hide();
            }
            
        }
    }
}
