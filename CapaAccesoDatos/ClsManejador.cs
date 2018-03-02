﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaAccesoDatos
{
    public class ClsManejador
    {
        SqlConnection Conexion = new SqlConnection("Data source = 65.99.252.110; Initial Catalog = ctzmx_tgcontrol; User Id = ctzmx_sa; password=Inttesi#2018");
        //Server=i3\\SQLEXPRESS; DataBase=tgcontrol;user=sa; password=Admin.2018; integrated security = true
        //Data source = 65.99.252.110; Initial Catalog = ctzmx_tgcontrol; User Id = ctzmx_sa; password=Inttesi#2018


        // metodo para abrir coneccion
        void abrir_conexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

        }

        void cerrar_conexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }

        // metodo para ejecutar el SP  Insert, update, delete 
        public void Ejecutar_sp(string NombreSP, List<ClsParametros> lst)
        {
            SqlCommand cmd;

            try
            {


                abrir_conexion(); // intentamos abrir la conexion
                cmd = new SqlCommand(NombreSP, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)   //recorremos la lista de parametros del SP en tratamiento
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);

                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamano).Direction = ParameterDirection.Output;
                        }

                    }
                }
                cmd.ExecuteNonQuery();
                for (int ii = 0; ii < lst.Count; ii++)
                        {
                            if (cmd.Parameters[ii].Direction == ParameterDirection.Output)
                                lst[ii].Valor = cmd.Parameters[ii].Value.ToString();  // else mensaje de salida del SP siempre va a ser cadena, mensaje de error
                        }

                
                
            }
            catch (Exception ex)
            {
                throw ex;   // si hay error cachamos el error

            }
            cerrar_conexion();  // si no hay error cerramos la conexion
        }


        // Metodo para listado o consultas  select
        public DataTable Listado(string NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();  // tipo de dato de visual studio contenedor de una tabla
            SqlDataAdapter Da;               // tipo de dato de visual studio contenedor de una tabla de SQL
            try
            {
                Da = new SqlDataAdapter(NombreSP, Conexion);   // este adaptador lo reconoce la libreria de sql como un contenedor de datos
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;  // le decimos al adaptador que es un tipo SP
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        //agregamos los parametros del SP al SQLAdapter para ser ejecutado por fill
                        Da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                Da.Fill(dt);
            }

            catch (Exception Ex)
            {
                throw Ex;
            }
            return dt;
        }
    }
}

