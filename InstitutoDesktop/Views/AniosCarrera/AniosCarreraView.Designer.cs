namespace InstitutoDesktop.Views.AniosCarrera
{
    partial class AniosCarreraView
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
            cboCarreras = new ComboBox();
            lblCarrera = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridAñosCarrera = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridAñosCarrera).BeginInit();
            SuspendLayout();
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(223, 43);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(313, 28);
            cboCarreras.TabIndex = 0;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(150, 48);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 1;
            lblCarrera.Text = "Carrera";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(97, 370);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(197, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(297, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridAñosCarrera
            // 
            dataGridAñosCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAñosCarrera.Location = new Point(97, 88);
            dataGridAñosCarrera.Name = "dataGridAñosCarrera";
            dataGridAñosCarrera.RowHeadersWidth = 51;
            dataGridAñosCarrera.Size = new Size(569, 262);
            dataGridAñosCarrera.TabIndex = 5;
            // 
            // AniosCarreraView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridAñosCarrera);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(lblCarrera);
            Controls.Add(cboCarreras);
            Name = "AniosCarreraView";
            Text = "Años de las Carreras";
            ((System.ComponentModel.ISupportInitialize)dataGridAñosCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCarreras;
        private Label lblCarrera;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridAñosCarrera;
    }
}