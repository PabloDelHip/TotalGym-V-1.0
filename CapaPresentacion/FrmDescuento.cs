using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
    public partial class FrmDescuento : Form
    {
        string nombreMembresia;
        double precioMembresia;
        public FrmDescuento(string nombreMembresi, double precioMembresia)
        {
            this.nombreMembresia = nombreMembresi;
            this.precioMembresia = precioMembresia;
            InitializeComponent();

        }

        private void FrmDescuento_Load(object sender, EventArgs e)
        {
            label1.Text = nombreMembresia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantiDescuento = Convert.ToDouble(txtDescuento.Text);
            if(precioMembresia<cantiDescuento)
            {
                MessageBox.Show("la cantidad de descuento es menor a la costo");
            }
            else
            {
                Login.cantidadDescuento = precioMembresia - cantiDescuento;
                this.Hide();
            }
           
        }
    }
}
