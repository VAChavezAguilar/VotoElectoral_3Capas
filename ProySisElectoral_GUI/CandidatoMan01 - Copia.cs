using System;
using System.Windows.Forms;
using ProySisElectoral_BL;

namespace ProySisElectoral_GUI
{
    public partial class CandidatoMan01 : Form
    {
        CandidatoBL objBL = new CandidatoBL();

        public CandidatoMan01()
        {
            InitializeComponent();
        }

        private void CandidatoMan01_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            dtrRegistros.DataSource = objBL.ListarCandidato();
        }

        // --- MÉTODOS QUE EL DESIGNER ESTABA BUSCANDO ---

        private void dtrRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Método requerido por el Designer
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Método requerido por el Designer
        }

        // --- EVENTOS DE TUS BOTONES ---

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CandidatoMan02 man02 = new CandidatoMan02();
            if (man02.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtrRegistros.CurrentRow != null)
            {
                CandidatoMan03 man03 = new CandidatoMan03();
                man03.idCandidato = dtrRegistros.CurrentRow.Cells[0].Value.ToString();

                if (man03.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila primero.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtrRegistros.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que deseas eliminar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dtrRegistros.CurrentRow.Cells[0].Value);
                    if (objBL.EliminarCandidato(id))
                    {
                        CargarDatos();
                    }
                }
            }
        }
    }
}