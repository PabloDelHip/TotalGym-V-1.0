﻿using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{

    public class ClsHdrVentaHist
    {

        public int m_IdSocio { get; set; }
        public double m_Subtotal { get; set; }
        public double m_IVA { get; set; }
        public double m_Total{ get; set; }
        public string m_User_modif { get; set; }
        public int m_tipoPago { get; set; }
        public int m_FolioVenta { get; set; }

        /**************Estructura*************/

        ClsManejador M = new ClsManejador();  // Referenciamos la clase para poder armar la estructura del SP
                                              // Checamos que exista el usuario

        public string guardarVenta()
        {
            string mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@idSocio", m_IdSocio));
                lst.Add(new ClsParametros("@Subtotal", m_Subtotal));
                lst.Add(new ClsParametros("@IVA", m_IVA));
                lst.Add(new ClsParametros("@Total", m_Total));
                lst.Add(new ClsParametros("@User_modif", m_User_modif));
                lst.Add(new ClsParametros("@tipoPago", m_tipoPago));

                /*Mensaje de salida*/
                lst.Add(new ClsParametros("@FolioVenta", SqlDbType.VarChar, 40));
                M.Ejecutar_sp("guardarVenta", lst);
                //Retornamos el mensaje  de salida del SP
                mensaje = lst[6].Valor.ToString();/////.valor 

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mensaje;
        }


        public string cancelarTicket()
        {
            string mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                lst.Add(new ClsParametros("@FolioVenta", m_FolioVenta));

                /*Mensaje de salida*/
                lst.Add(new ClsParametros("@respuesta", SqlDbType.VarChar, 40));
                M.Ejecutar_sp("cancelar_ticket", lst);
                //Retornamos el mensaje  de salida del SP
                mensaje = lst[1].Valor.ToString();/////.valor 

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mensaje;
        }


    }
}
