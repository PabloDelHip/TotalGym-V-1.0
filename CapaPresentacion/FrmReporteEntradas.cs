using CapaLogicaNegocios;
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
    public partial class FrmReporteEntradas : Form
    {
        public int idSocio;
        public DateTime fechaInicioBusqueda;
        public DateTime fechaFinBusqueda;
        public FrmReporteEntradas()
        {
            InitializeComponent();
        }

        private void FrmReporteEntradas_Load(object sender, EventArgs e)
        {
     
        }

        private void FrmReporteEntradas_Load_1(object sender, EventArgs e)
        {
            switch (Login.opcionReporte)
            {
                case 1:
                    CREntradas reporteEntradas = new CREntradas();
                    reporteEntradas.SetParameterValue("@idSocio", idSocio);
                    reporteEntradas.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteEntradas.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteEntradas;
                    break;
                case 2:
                    CRHisObGenerales reporteHisObGenerales = new CRHisObGenerales();
                    reporteHisObGenerales.SetParameterValue("@idSocio", idSocio);
                    reporteHisObGenerales.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObGenerales.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObGenerales;
                    break;
                case 3:
                    CRHisObCaja reporteHisObCaja = new CRHisObCaja();
                    reporteHisObCaja.SetParameterValue("@idSocio", idSocio);
                    reporteHisObCaja.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObCaja.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObCaja;
                    break;
                case 4:
                    CRVentas reporteVentas = new CRVentas();
                    reporteVentas.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteVentas.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteVentas;
                    break;
                case 5:
                    CRHisObGeneralesID reporteHisObGeneralesID = new CRHisObGeneralesID();
                    reporteHisObGeneralesID.SetParameterValue("@idSocio", idSocio);
                    CRVreporteEntradas.ReportSource = reporteHisObGeneralesID;
                    break;
                case 6:
                    CRHisObCajaID reporteHisObCajaID = new CRHisObCajaID();
                    reporteHisObCajaID.SetParameterValue("@IdSocio", idSocio);
                    CRVreporteEntradas.ReportSource = reporteHisObCajaID;
                    break;
                case 7:
                    CRHisObGeneralesFecha reporteHisObGeneralesFecha = new CRHisObGeneralesFecha();
                    reporteHisObGeneralesFecha.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObGeneralesFecha.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObGeneralesFecha;
                    break;
                case 8:
                    CRHisObCajaFecha reporteHisObCajaFecha = new CRHisObCajaFecha();
                    reporteHisObCajaFecha.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObCajaFecha.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObCajaFecha;
                    break;
                case 9:
                    CRMovimientoCajaFecha reporteMovCajaFecha = new CRMovimientoCajaFecha();
                    reporteMovCajaFecha.SetParameterValue("@Fecha", fechaInicioBusqueda);
                    CRVreporteEntradas.ReportSource = reporteMovCajaFecha;
                    break;
                case 10:
                    CRMovimientoCajaUsuario reporteMovCajaUsuario = new CRMovimientoCajaUsuario();
                    reporteMovCajaUsuario.SetParameterValue("@idUsuario", idSocio);
                    CRVreporteEntradas.ReportSource = reporteMovCajaUsuario;
                    break;
                default:
                    break;
            }

        }

        private void CRVreporteEntradas_Load(object sender, EventArgs e)
        {

        }
    }
}
