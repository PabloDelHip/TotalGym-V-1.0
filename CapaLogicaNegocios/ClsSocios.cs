﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace CapaLogicaNegocios
{
    public class ClsSocios
    {
        // estructura de la tabla
        public Int64 m_IdSocio { get; set; }
        public string m_FotoId { get; set; }
        public string m_Nombre { get; set; }
        public string m_Direccion1 { get; set; }
        public string m_Direccion2 { get; set; }
        public string m_Email { get; set; }
        public string m_Edad { get; set; }
        public string m_Telefono { get; set; }
        public string m_Sexo { get; set; }
        public string m_TipoSocio { get; set; }
        public string m_Fingerprint { get; set; }
        public DateTime m_FechaIngreso { get; set; }
        public DateTime m_Vencimiento { get; set; }
        public string m_Observacion { get; set; }
        public string m_Indicaciones { get; set; }
        public string m_User_modif { get; set; }
        public byte[] m_Foto { get; set; }
        public DateTime m_FechaInicio { get; set; }
        public DateTime m_FechaFinal { get; set; }
        public int m_NumeroDias { get; set; }
        public int m_TipoBusqueda { get; set; }
        public DateTime m_FechaNacimiento { get; set; }

        ClsManejador M = new ClsManejador();  // Referenciamos la clase para poder armar la estructura del SP
                                              // Checamos que exista el usuario
       

        public string    InsSocio()            
        {
            string  IdSocio;
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
                lst.Add(new ClsParametros("@FotoId", m_FotoId));
                lst.Add(new ClsParametros("@Nombre", m_Nombre));
                lst.Add(new ClsParametros("@Direccion1", m_Direccion1));
                lst.Add(new ClsParametros("@Direccion2", m_Direccion2));
                lst.Add(new ClsParametros("@Email", m_Email));
                lst.Add(new ClsParametros("@Edad", m_Edad));
                lst.Add(new ClsParametros("@Telefono", m_Telefono));
                lst.Add(new ClsParametros("@Sexo", m_Sexo));
                lst.Add(new ClsParametros("@TipoSocio", m_TipoSocio));
                //lst.Add(new ClsParametros("@Finguerprint", m_Fingerprint));
                //lst.Add(new ClsParametros("@FechaIngreso", m_FechaIngreso));
               // lst.Add(new ClsParametros("@Vencimiento", m_Vencimiento));
                lst.Add(new ClsParametros("@Observacion", m_Observacion));
                lst.Add(new ClsParametros("@Indicaciones", m_Indicaciones));
                lst.Add(new ClsParametros("@User_modif", m_User_modif));
                lst.Add(new ClsParametros("@Foto", m_Foto));
                lst.Add(new ClsParametros("@FechaNacimiento", m_FechaNacimiento));
                //Parametros de salida
                lst.Add(new ClsParametros("@Exito", SqlDbType.VarChar , 40));


                M.Ejecutar_sp("AltaSocio", lst);
                //Retornamos el mensaje  de salida del SP
                IdSocio = lst[15].Valor.ToString(); /////.valor 

                



            }
            catch (Exception ex)
            {
                throw ex;
            }

            return IdSocio;

        }

        public string ConsultarSocio()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            //variable validar si el usuario fue encontrado o no
            string bandera;
            //Parametro de entrada
            lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
            //PArametro de salida
            lst.Add(new ClsParametros("@Encontrado", SqlDbType.VarChar, 1));
            M.Ejecutar_sp("buscar_socio", lst);
            //Retornamos el mensaje  de salida del SP
            bandera = lst[1].Valor.ToString();/////.valor 
            return bandera;
        }

        // metodo para regresar el alimno
        public DataTable RegresaSocio()  
        {
            List<ClsParametros> lst = new List<ClsParametros>();

            lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
            return  M.Listado("RegresaSocio", lst);
            
        }

        // metodo para regresar el alimno
        public DataTable buscarSocioPorNombre()
        {
            List<ClsParametros> lst = new List<ClsParametros>();

            lst.Add(new ClsParametros("@nombre", m_Nombre));
            return M.Listado("buscar_socio_por_nombre", lst);

        }

        // metodo para regresar los movimientos del socio
        public DataTable movimientosSocios()
        {
            List<ClsParametros> lst = new List<ClsParametros>();

            lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
            return M.Listado("movimientos_socio", lst);

        }

        public DataTable buscarSocioDiasViajero()
        {
            List<ClsParametros> lst = new List<ClsParametros>();

            lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
            return M.Listado("buscar_socio_dias_viajero", lst);

        }

        public void conectarAlServidor(int idSocio)
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // paso 2 - creamos el socket

            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse("192.168.1.15"), 1234);

            //paso 3 - Acá debemos poner la Ip del servidor, y el puerto de escucha del servidor

            //Yo puse esa porque corrí las dos aplicaciones en la misma pc

            try

            {
                
                miPrimerSocket.Connect(miDireccion); // Conectamos               
                byte[] textoEnviar;
                textoEnviar = Encoding.Default.GetBytes(Convert.ToString(idSocio)); //pasamos el texto a array de bytes
                miPrimerSocket.Send(textoEnviar, 0, textoEnviar.Length, 0);
                miPrimerSocket.Close();

            }

            catch (Exception ex)
            {

                throw ex;

            }


        }

        public DataTable DatosSocio()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@IdSocio", m_IdSocio));
            return M.Listado("mostrar_imagen", lst);
        }

        public DataTable DatosSociosVencidos()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@idSocio", m_IdSocio));
            lst.Add(new ClsParametros("@FechaInicio", m_FechaInicio));
            lst.Add(new ClsParametros("@FechaFinal", m_FechaFinal));
            lst.Add(new ClsParametros("@NumeroDias", m_NumeroDias));
            lst.Add(new ClsParametros("@TipoBusqueda", m_TipoBusqueda));
            return M.Listado("socio_fecha_vencimiento", lst);
        }

        public DataTable EnviarEmailSocios()
        {
            return M.Listado("enviar_email", null);
        }

        public DataTable EnviarEmailCumpleañeros()
        {
            return M.Listado("fecha_nacimiento", null);
        }


    }
}
