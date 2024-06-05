using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCosmeticaSosa
{
    public partial class frmBuscarPostulante : Form
    {
        public frmBuscarPostulante()
        {
            InitializeComponent();
        }

        private void dgvPostulante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = cmbBusqueda.SelectedIndex;

            switch(seleccion)
            {
                case 0:
                    if(cmbArea.Visible == true)
                    {
                        cmbArea.Visible = false;
                    }
                    txtBusqueda.Visible = true;
                break;

                case 1:
                    if (cmbArea.Visible == true)
                    {
                        cmbArea.Visible = false;
                    }
                    txtBusqueda.Visible = true;
                break;

                case 2:
                    if (cmbArea.Visible == true)
                    {
                        cmbArea.Visible = false;
                    }
                    txtBusqueda.Visible = true;
                break;

                case 3:
                    if (cmbArea.Visible == true)
                    {
                        cmbArea.Visible = false;
                    }
                    txtBusqueda.Visible = true;
                break;

                case 4:
                    if (cmbArea.Visible == true)
                    {
                        cmbArea.Visible = false;
                    }
                    txtBusqueda.Visible = true;
                break;

                case 5:
                    if(txtBusqueda.Visible == true)
                    {
                        txtBusqueda.Visible = false;
                    }
                    cmbArea.Visible = true;
                break;

            }
        }
    }
}
