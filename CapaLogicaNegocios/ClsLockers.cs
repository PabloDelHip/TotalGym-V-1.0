using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocios
{
    public class ClsLockers
    {
        /**************Estructura*************/

        public int m_idLocker { get; set; }
        public string m_Descripcion { get; set; }
        public char m_TipoLocker { get; set; }
        public char m_Sexo { get; set; }
        public char m_Ocupado{ get; set; }
        public char m_Status { get; set; }
        public DateTime m_Fecha_modif { get; set; }
        public string m_User_modif { get; set; }
        public int m_idSocio { get; set; }
        public DateTime m_fechaVencimiento { get; set; }
        public int Tipo { get; set; }
        public int numeroDias { get; set; }
        public int periodoLocker { get; set; }

        ClsManejador M = new ClsManejador();

        public DataTable verLockers()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Tipo", Tipo));
            return M.Listado("seleccionar_lockers", lst);
        }

        public DataTable seleccinarMembresiaTipoLockers()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            return M.Listado("seleccionar_membresia_tipo_lockers", lst);
        }

        public DataTable buscarLockerSocio()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@idSocio", m_idSocio));
            return M.Listado("buscar_locker_socio", lst);
        }

        public void modificar_locker()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@idLocker", m_idLocker));
            lst.Add(new ClsParametros("@Descripcion", m_Descripcion));
            lst.Add(new ClsParametros("@Sexo", m_Sexo));
            lst.Add(new ClsParametros("@Status", m_Status));
            lst.Add(new ClsParametros("@idSocio", m_idSocio));
            lst.Add(new ClsParametros("@numeroDias", numeroDias));
            lst.Add(new ClsParametros("@Tipo", Tipo));
            M.Ejecutar_sp("modificar_locker", lst);
        }

        public string buscar_lockers_ocupados()
        {
             string respuesta;
             List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@idSocio", m_idSocio));
                //Parametros de salida
                lst.Add(new ClsParametros("@Respuesta", SqlDbType.VarChar, 1));


                M.Ejecutar_sp("buscar_lockers_ocupados", lst);
                //Retornamos el mensaje  de salida del SP
                respuesta = lst[1].Valor.ToString(); /////.valor 

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return respuesta;
        }

        
    }
}
