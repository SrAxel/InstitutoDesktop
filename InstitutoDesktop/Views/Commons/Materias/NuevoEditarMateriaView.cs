﻿using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.Models.Commons;
using InstitutoDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Commons.Materias
{
    public partial class NuevoEditarMateriaView : Form
    {
        MateriaService materiaService = new MateriaService();
        Materia materia;

        // NUEVO
        public NuevoEditarMateriaView(Carrera carrera, AnioCarrera anioCarrera)
        {
            InitializeComponent();
            materia = new Materia { AnioCarreraId = anioCarrera.Id };

            // Mostrar el año y carrera combinados en el TextBox
            txtAnioYCarrera.Text = anioCarrera.AñoYCarrera;

        }
        // EDITAR
        public NuevoEditarMateriaView(Materia materia, AnioCarrera anioCarrera)
        {
            InitializeComponent();
            this.materia = materia;
            // Mostrar el año y carrera combinados en el TextBox
            if (anioCarrera != null)
            {
                txtAnioYCarrera.Text = anioCarrera.AñoYCarrera;
            }
            // Mostrar el nombre de la materia en el TextBox correspondiente
            txtMateria.Text = materia.Nombre;
        }

            private async void btnGuardar_Click(object sender, EventArgs e)
        {

            materia.Nombre = txtMateria.Text;

            if (materia.Id == 0)
            {
                await materiaService.AddAsync(materia);

            }
            else
            {
                await materiaService.UpdateAsync(materia);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
