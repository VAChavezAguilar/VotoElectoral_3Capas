using System;
using System.Data;
using System.Windows.Forms;
using ProySisElectoral_BE;
using ProySisElectoral_BL;

namespace ProySisElectoral_GUI
{
    public partial class CandidatoMan03 : Form
    {
        public string idCandidato;
        CandidatoBL objBL = new CandidatoBL();

        public CandidatoMan03()
        {
            InitializeComponent();
        }

        // Método para recibir el ID desde el Man01
        public void SetIdCandidato(string id)
        {
            this.idCandidato = id;
        }

        private void CandidatoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Usamos ListarCandidato (que ya tienes) y filtramos en memoria
                DataTable dtTodos = objBL.ListarCandidato();

                // Filtramos por el ID. ¡OJO! Asegúrate que "id_candidato" sea el nombre 
                // exacto de la columna en tu DataTable.
                DataRow[] filas = dtTodos.Select($"id_candidato = {Convert.ToInt32(idCandidato)}");

                if (filas.Length > 0)
                {
                    DataRow dr = filas[0];
                    txtNombres.Text = dr["nombres"].ToString();
                    txtApellidos.Text = dr["apellidos"].ToString();
                    txtIdPartido.Text = dr["id_partido"].ToString();
                    txtIdEleccion.Text = dr["id_eleccion"].ToString();
                    txtSexo.Text = dr["sexo"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtIdUbigeo.Text = dr["id_Ubigeo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                CandidatoBE obj = new CandidatoBE();
                obj.id_candidato = Convert.ToInt32(idCandidato);
                obj.nombres = txtNombres.Text.Trim();
                obj.apellidos = txtApellidos.Text.Trim();
                obj.id_partido = Convert.ToInt32(txtIdPartido.Text);
                obj.id_eleccion = Convert.ToInt32(txtIdEleccion.Text);
                obj.sexo = txtSexo.Text.Trim();
                obj.direccion = txtDireccion.Text.Trim();
                obj.Id_Ubigeo = txtIdUbigeo.Text.Trim();

                if (objBL.ActualizarCandidato(obj))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}