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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FrmCatMemebresias : Form
    {
        ClsMembresias cls_membresias = new ClsMembresias();
        ClsClvMembresias cls_clv_membresias = new ClsClvMembresias();
        int Dom;
        int Lun;
        int Mar;
        int Mier;
        int Jue;
        int Vie;
        int Sab;
        int Matutino;
        string HoraInicioiMaT;
        string HoraFinalMat;
        int Vespertino;
        string HoraInicioVesp;
        string HoraFinalVesp;
        int Activa;
        int Viajero;
        int ConteoViajero;
        int Grupal;
        int numPersonasGrupal;
        string prefijo;
        int BanderaPrefijo;

        public FrmCatMemebresias()
        {
            InitializeComponent();
        }

        private void validarDias()
        {
            if (chkDomingo.Checked)
            {
                Dom = 1;
            }
            else
            {
                Dom = 0;
            }

            if (chkLunes.Checked)
            {
                Lun = 1;
            }
            else
            {
                Lun = 0;
            }

            if (chkMartes.Checked)
            {
                Mar = 1;
            }
            else
            {
                Mar = 0;
            }

            if (chkMiercoles.Checked)
            {
                Mier = 1;
            }
            else
            {
                Mier = 0;
            }

            if (chkJueves.Checked)
            {
                Jue = 1;
            }
            else
            {
                Jue = 0;
            }

            if (chkViernes.Checked)
            {
                Vie = 1;
            }
            else
            {
                Vie = 0;
            }

            if (chkSabado.Checked)
            {
                Sab = 1;
            }
            else
            {
                Sab = 0;
            }
        }

        private void validarHorarios()
        {
            if(chkMatutino.Checked)
            {
                Matutino = 1;
                HoraInicioiMaT = mktHoraInicioMatutino.Text;
                HoraFinalMat = mktHoraFinalMatutino.Text;
            }
            else
            {
                Matutino = 0;
                HoraInicioiMaT = "0";
                HoraFinalMat = "0";
            }

            if(chkVespertino.Checked)
            {
                Vespertino = 1;
                HoraInicioVesp = mktHoraInicioVespertino.Text;
                HoraFinalVesp = mktHoraFinalVespertino.Text;
            }
            else
            {
                Vespertino = 0;
                HoraInicioVesp = "0";
                HoraFinalVesp = "0";
            }

        }

        public void validarDatosExtras()
        {
            if(chkActiva.Checked)
            {
                Activa = 1;
            }
            else
            {
                Activa = 0;
            }

            if(chkViajero.Checked)
            {
                Viajero = 1;
                ConteoViajero = Convert.ToInt32(txtDiasViajero.Text);
            }
            else
            {
                Viajero = 0;
                ConteoViajero = 0;
            }

            if(chkGrupal.Checked)
            {
                Grupal = 1;
                numPersonasGrupal = Convert.ToInt32(txtNumPersonasGrupal.Text);
            }
            else
            {
                Grupal = 0;
                numPersonasGrupal = 0;
            }

            if(chkPrefijo.Checked)
            {
                BanderaPrefijo = 1;
                prefijo = txtClavePrefijo.Text;
            }
            else
            {
                BanderaPrefijo = 0;
                prefijo = "";
            }
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            validarDias();
            validarHorarios();
            validarDatosExtras();
            cls_membresias.m_Descripcion = txtDescripcion.Text;
            cls_membresias.m_Tipo = 'M';
            cls_membresias.m_Costo = Convert.ToDouble(txtCosto.Text);
            cls_membresias.m_Perdiodo = Convert.ToInt32(txtPeriodo.Text);
            cls_membresias.m_User_modif = Login.nombre;
            cls_membresias.m_Dom = Dom;
            cls_membresias.m_Lun = Lun;
            cls_membresias.m_Mar = Mar;
            cls_membresias.m_Mier = Mier;
            cls_membresias.m_Jue = Jue;
            cls_membresias.m_Vie = Vie;
            cls_membresias.m_Sab = Sab;
            cls_membresias.m_Matutino = Matutino;
            cls_membresias.m_HoraInicioiMaT = HoraInicioiMaT;
            cls_membresias.m_HoraFinalMat = HoraFinalMat;
            cls_membresias.m_Vespertino = Vespertino;
            cls_membresias.m_HoraInicioVesp = HoraInicioVesp;
            cls_membresias.m_HoraFinalVesp = HoraFinalVesp;
            cls_membresias.m_Activa = Activa;
            cls_membresias.m_Viajero = Viajero;
            cls_membresias.m_ConteoViajero = ConteoViajero;
            cls_membresias.m_Grupal = Grupal;
            cls_membresias.m_numeroPersonasGrupal = numPersonasGrupal;
            cls_membresias.m_prefijo = txtClavePrefijo.Text;
            cls_membresias.m_BanderaPrefijo = BanderaPrefijo;



            string respuesta = cls_membresias.altaMembresias();
            MessageBox.Show(respuesta);
        }

        private void llenarComboClveMembresia()
        {

            DataTable dt = cls_clv_membresias.seleccionarClvMembresias();
            //se llena el datasoucer con lo que regreso el SP
            cmbTipo.DataSource = dt;
            //se coloca el indice o option en web
            cmbTipo.ValueMember = "clvMembresia";
            //se coloca el valor del combo
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.Text = "";
        }

        private void FrmCatMemebresias_Load(object sender, EventArgs e)
        {
            llenarComboClveMembresia();
        }
    }
}
