﻿using System;
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
    public partial class FrmCorteSalida : Form
    {
        ClsCorteCaja cls_corte_caja = new ClsCorteCaja();
        double totalDinero;
        double dineroEnCaja;
        double totalEfectivoCaja;
        verReporte VER;
        Datos DS = new Datos();
        public FrmCorteSalida()
        {
            InitializeComponent();
        }

        private void FrmCorteSalida_Load(object sender, EventArgs e)
        {
            Login.cerrarSesion = false;

            cls_corte_caja.m_idUsuario = Login.idUsuario;
            cls_corte_caja.m_user_modif = Login.nombre;
           DataTable dt = cls_corte_caja.sumaTotalCorte();
           totalEfectivoCaja = 0;
            foreach (DataRow filas in dt.Rows)
            {
                totalEfectivoCaja = Convert.ToDouble(filas["totalVentasEfectivo"].ToString()) + Convert.ToDouble(filas["totalMovimientoCaja"].ToString());
                txtDineroEfectivo.Text = totalEfectivoCaja.ToString();
                
                txtDineroTarjeta.Text = filas["totalVentasTarjeta"].ToString();
                totalDinero = totalEfectivoCaja + Convert.ToDouble(txtDineroTarjeta.Text);
            }

            dgvMovimientos.DataSource = cls_corte_caja.seleccionarMovimientosCajaCorte();
            dgvEfectivo.DataSource = cls_corte_caja.seleccionarMovimientosVentaEfectivo();
            dgvTarjetas.DataSource =  cls_corte_caja.seleccionarMovimientosVentaTarjeta();
            DataTable dtMovimientos = cls_corte_caja.seleccionarMovimientosCajaCorte();
            DataTable dtEfectivo = cls_corte_caja.seleccionarMovimientosVentaEfectivo();
            DataTable dtTarjeta = cls_corte_caja.seleccionarMovimientosVentaTarjeta();
           
            foreach (DataRow filas in dtMovimientos.Rows)
            {
                int idMovimientoCaja = Convert.ToInt32(filas["idMovimientoCaja"].ToString());
                double cantidad = Convert.ToDouble(filas["cantidad"].ToString());
                string detalle = filas["detalle"].ToString();
                string Fecha = filas["Fecha"].ToString();
                DS.MovimientoCaja.Rows.Add(idMovimientoCaja, cantidad, detalle, Fecha);
            }

            foreach (DataRow filas in dtEfectivo.Rows)
            {
                int FolioVenta = Convert.ToInt32(filas["FolioVenta"].ToString());
                string User_modif = filas["User_modif"].ToString();
                string FechaMovimiento = filas["FechaMovimiento"].ToString();
                double Total = Convert.ToDouble(filas["Subtotal"].ToString());
                DS.MovimientoEfectivo.Rows.Add(FolioVenta, User_modif, FechaMovimiento,Total);
            }

            foreach (DataRow filas in dtTarjeta.Rows)
            {
                int FolioVenta = Convert.ToInt32(filas["FolioVenta"].ToString());
                string User_modif = filas["User_modif"].ToString();
                string FechaMovimiento = filas["FechaMovimiento"].ToString();
                double Total = Convert.ToDouble(filas["Subtotal"].ToString());
                DS.MovimientoTarjeta.Rows.Add(FolioVenta, User_modif, FechaMovimiento, Total);
            }

           
        }

        public void guardarMovimiento()
        {
            cls_corte_caja.m_Supervisor = Login.Supernombre;
            cls_corte_caja.m_idUsuario = Login.idUsuario;
            cls_corte_caja.m_totalCaja = totalEfectivoCaja;
            cls_corte_caja.m_totalTarjeta = Convert.ToDouble(txtDineroTarjeta.Text);
            cls_corte_caja.m_totalCorte = dineroEnCaja;
            string respuesta = cls_corte_caja.movimientoCorteCajaEntrada();
            MessageBox.Show(respuesta);
            Login.cerrarSesion = true;
            VER = new verReporte(DS.MovimientoEfectivo, DS.MovimientoTarjeta, DS.MovimientoCaja);
            //VER.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dineroEnCaja = Convert.ToDouble(txtDineroSalida.Text);
            if(totalDinero>dineroEnCaja)
            {
                if (MessageBox.Show("El dinero en caja es menor. \n ¿Seguro que desea continuar?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   guardarMovimiento();
                }
            }
            else
            {
                if (MessageBox.Show("¿Realizar corte?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   guardarMovimiento();
            }

            
            //double dineroCaja = Convert.ToDouble(txtDineroEfectivo.Text);
            //double dineroSalida = Convert.ToDouble(txtDineroSalida.Text);
            //cls_corte_caja.m_Supervisor = "supervisor";
            //cls_corte_caja.m_cantidadCorte = dineroSalida;

            //if (dineroCaja > dineroSalida)
            //{
            //    MessageBox.Show("el dinero es menor");
            //}
            //else if(dineroCaja<=dineroSalida)
            //{
            //    MessageBox.Show("dinero correcto");
            //    cls_corte_caja.cerrarCaja();
            //    MessageBox.Show("bien");
            //    this.Hide();
            //    Login.tipoObservacion = 2;
            //    FrmObservacion observacion = new FrmObservacion(3);
            //    observacion.ShowDialog();
            //}
        }
    }
}
