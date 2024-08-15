namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    partial class AnioCarreraView
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
            label1 = new Label();
            comboCarreras = new ComboBox();
            dataGridAniosCarrera = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Carrera:";
            // 
            // comboCarreras
            // 
            comboCarreras.FormattingEnabled = true;
            comboCarreras.Location = new Point(147, 25);
            comboCarreras.Name = "comboCarreras";
            comboCarreras.Size = new Size(578, 28);
            comboCarreras.TabIndex = 1;
            // 
            // dataGridAniosCarrera
            // 
            dataGridAniosCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAniosCarrera.Location = new Point(81, 70);
            dataGridAniosCarrera.Name = "dataGridAniosCarrera";
            dataGridAniosCarrera.RowHeadersWidth = 51;
            dataGridAniosCarrera.Size = new Size(644, 293);
            dataGridAniosCarrera.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 37);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(224, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 37);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(418, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 37);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(643, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 37);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // AnioCarreraView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridAniosCarrera);
            Controls.Add(comboCarreras);
            Controls.Add(label1);
            Name = "AnioCarreraView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Años Carrera";
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboCarreras;
        private DataGridView dataGridAniosCarrera;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}