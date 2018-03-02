using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteMovCaja : Form
    {
        public int idUsuario;
        public DateTime fecha;
        public int opc;
        public FrmReporteMovCaja()
        {
            InitializeComponent();
        }

        private void FrmReporteMovCaja_Load(object sender, EventArgs e)
        {
            CRMovCaja reporteCaja = new CRMovCaja();
            CRMovCajaFecha reporteCajaFecha = new CRMovCajaFecha();
            if (opc==1)
            {
                reporteCajaFecha.SetParameterValue("@FechaHora", fecha);
                crvMovCaja.ReportSource = reporteCajaFecha;
            }
            else if (opc==2)
            {
                reporteCaja.SetParameterValue("@idUsuario", idUsuario);
                crvMovCaja.ReportSource = reporteCaja;
            }
        }
    }
}
