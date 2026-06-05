using System;
using System.Windows.Forms;
using ProySisElectoral_BE;
using ProySisElectoral_BL;

namespace ProySisElectoral_GUI
{
    public partial class CandidatoMan02 : Form
    {
        // Instancia del BL
        CandidatoBL objBL = new CandidatoBL();

        public CandidatoMan02()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos el objeto con los datos del form
                CandidatoBE obj = new CandidatoBE();

                obj.nombres = txtNombres.Text.Trim();
                obj.apellidos = txtApellidos.Text.Trim();
                obj.id_partido = Convert.ToInt32(txtIdPartido.Text);
                obj.id_eleccion = Convert.ToInt32(txtIdEleccion.Text);
                obj.sexo = txtSexo.Text.Trim();
                obj.direccion = txtDireccion.Text.Trim();
                obj.Id_Ubigeo = txtIdUbigeo.Text.Trim();

                // Llamamos al método de insertar
                if (objBL.InsertarCandidato(obj))
                {
                    // Esto cierra el formulario y avisa al Man01 que todo salió bien
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el candidato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}