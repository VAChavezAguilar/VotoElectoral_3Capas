namespace ProySisElectoral_GUI
{
    partial class MesaMan01
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
            dgvMesa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMesa).BeginInit();
            SuspendLayout();
            // 
            // dgvMesa
            // 
            dgvMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesa.Location = new Point(291, 172);
            dgvMesa.Name = "dgvMesa";
            dgvMesa.RowHeadersWidth = 51;
            dgvMesa.Size = new Size(300, 188);
            dgvMesa.TabIndex = 0;
            // 
            // MesaMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMesa);
            Name = "MesaMan01";
            Text = "MesaMan01";
            Load += MesaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMesa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMesa;
    }
}