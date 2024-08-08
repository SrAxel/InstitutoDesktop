namespace InstitutoDesktop.Views
{
    partial class CarrerasView
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
            dataGridCarreras = new DataGridView();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridCarreras).BeginInit();
            SuspendLayout();
            // 
            // dataGridCarreras
            // 
            dataGridCarreras.AllowUserToAddRows = false;
            dataGridCarreras.AllowUserToDeleteRows = false;
            dataGridCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCarreras.Location = new Point(74, 47);
            dataGridCarreras.Margin = new Padding(4, 5, 4, 5);
            dataGridCarreras.Name = "dataGridCarreras";
            dataGridCarreras.ReadOnly = true;
            dataGridCarreras.RowHeadersWidth = 62;
            dataGridCarreras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCarreras.Size = new Size(980, 518);
            dataGridCarreras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(105, 591);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(308, 591);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(159, 50);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Editar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton2.IconSize = 24;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(514, 591);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(159, 50);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Eliminar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton3.IconSize = 24;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(982, 622);
            iconButton3.Margin = new Padding(4, 5, 4, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(159, 50);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "Salir";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // CarrerasView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 686);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridCarreras);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CarrerasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carreras";
            ((System.ComponentModel.ISupportInitialize)dataGridCarreras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCarreras;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}