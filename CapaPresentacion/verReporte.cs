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
    public partial class verReporte : Form
    {
        public verReporte(DataTable DT, DataTable DT2, DataTable DT3)
        {
            InitializeComponent();
            //Crear Objeto REPORTE
            //CRTicketVenta RP = new CRTicketVenta();
            CRTicketCorte RP = new CRTicketCorte();
            crystalReportViewer1.ReportSource = RP;
            RP.Refresh();
            if (DT2!=null)
            {
                RP.Subreports[0].SetDataSource(DT);
                RP.Subreports[1].SetDataSource(DT2);
                RP.Subreports[2].SetDataSource(DT3);
            }
            //Asignar datos al reporte
            //Asignar reporte creado al visor de reportes
           // RP.PrintToPrinter(1, false, 0, 0);
            

          //  RP2.SetDataSource(DT2);
            
            //RP.Subreports[1].SetDataSource(DT);
            crystalReportViewer1.ReportSource = RP;
            RP.PrintToPrinter(1, false, 0, 0);


        }

        private void verReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
