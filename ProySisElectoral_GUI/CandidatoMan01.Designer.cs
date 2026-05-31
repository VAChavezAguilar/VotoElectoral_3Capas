namespace ProySisElectoral_GUI
{
    partial class CandidatoMan01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblBuscar = new Label();
            txtFiltro = new TextBox();
            dtrRegistros = new DataGridView();
            pnlAcciones = new Panel();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtrRegistros).BeginInit();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(97, 50);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(69, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "lblBuscar";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(198, 50);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(125, 27);
            txtFiltro.TabIndex = 2;
            // 
            // dtrRegistros
            // 
            dtrRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtrRegistros.Dock = DockStyle.Fill;
            dtrRegistros.Location = new Point(0, 0);
            dtrRegistros.Name = "dtrRegistros";
            dtrRegistros.RowHeadersWidth = 51;
            dtrRegistros.Size = new Size(800, 450);
            dtrRegistros.TabIndex = 3;
            dtrRegistros.CellContentClick += dtrRegistros_CellContentClick;
            // 
            // pnlAcciones
            // 
            pnlAcciones.Controls.Add(btnEliminar);
            pnlAcciones.Controls.Add(btnActualizar);
            pnlAcciones.Controls.Add(btnInsertar);
            pnlAcciones.Dock = DockStyle.Bottom;
            pnlAcciones.Location = new Point(0, 325);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(800, 125);
            pnlAcciones.TabIndex = 4;
            pnlAcciones.Paint += panel1_Paint;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(80, 57);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "button1";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(347, 64);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "button2";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(601, 64);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "button3";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // CandidatoMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAcciones);
            Controls.Add(dtrRegistros);
            Controls.Add(txtFiltro);
            Controls.Add(lblBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CandidatoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de candidatos";
            ((System.ComponentModel.ISupportInitialize)dtrRegistros).EndInit();
            pnlAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label lblBuscar;
        private TextBox txtFiltro;
        private DataGridView dtrRegistros;
        private Panel pnlAcciones;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnInsertar;
    }
}