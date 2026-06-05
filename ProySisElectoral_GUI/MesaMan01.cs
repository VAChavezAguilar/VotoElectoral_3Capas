using System;
using System.Windows.Forms;
using ProySisElectoral_BL;

namespace ProySisElectoral_GUI
{
    public partial class MesaMan01 : Form
    {
        MesaBL objBL = new MesaBL();

        public MesaMan01()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            dgvMesa.DataSource = objBL.ListarMesa();
        }

        private void MesaMan01_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}   
