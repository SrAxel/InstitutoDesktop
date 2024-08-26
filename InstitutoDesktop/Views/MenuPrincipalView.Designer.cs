namespace InstitutoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            btnAlumnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconDocente = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, iconMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1091, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 40;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(104, 28);
            iconMenuItem1.Text = "Principal";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem7, iconMenuItem6, btnAlumnos, iconMenuItem5, iconDocente });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(84, 28);
            iconMenuItem2.Text = "Bases";
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.BackColor = Color.Lavender;
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(176, 26);
            iconMenuItem7.Text = "Horas";
            iconMenuItem7.Click += iconMenuItem7_Click;
            // 
            // iconMenuItem6
            // 
            iconMenuItem6.BackColor = Color.Lavender;
            iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Hurricane;
            iconMenuItem6.IconColor = Color.Black;
            iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem6.Name = "iconMenuItem6";
            iconMenuItem6.Size = new Size(176, 26);
            iconMenuItem6.Text = "Ciclo Lectivo";
            iconMenuItem6.Click += iconMenuItem6_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.Lavender;
            btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnAlumnos.IconColor = Color.Black;
            btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(176, 26);
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.BackColor = Color.Lavender;
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.School;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(176, 26);
            iconMenuItem5.Text = "Carreras";
            iconMenuItem5.Click += iconMenuItem5_Click;
            // 
            // iconDocente
            // 
            iconDocente.BackColor = Color.Lavender;
            iconDocente.IconChar = FontAwesome.Sharp.IconChar.User;
            iconDocente.IconColor = Color.Black;
            iconDocente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconDocente.Name = "iconDocente";
            iconDocente.Size = new Size(176, 26);
            iconDocente.Text = "Docentes";
            iconDocente.Click += iconDocente_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem4 });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(76, 28);
            iconMenuItem3.Text = "Salir";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.BackColor = Color.Lavender;
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(200, 26);
            iconMenuItem4.Text = "Salir del sistema";
            iconMenuItem4.Click += iconMenuItem4_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1091, 662);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipalView";
            Text = "Instituto Superior de Profesorado Nº20";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;

        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;


        private FontAwesome.Sharp.IconMenuItem btnAlumnos;

        private FontAwesome.Sharp.IconMenuItem iconDocente;

    }
}
