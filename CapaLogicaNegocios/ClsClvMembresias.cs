using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocios
{
   public class ClsClvMembresias
    {
        public int m_idClaveMembresias { get; set; }
        public char m_clvMembresia { get; set; }
        public string m_Descripcion { get; set; }

        ClsManejador M = new ClsManejador();

        public DataTable seleccionarClvMembresias()
        {
            return M.Listado("seleccionar_ClvMembresias",null);
        }
    }
}
