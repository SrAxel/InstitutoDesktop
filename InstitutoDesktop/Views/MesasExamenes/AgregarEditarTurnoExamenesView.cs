﻿using BlazorAppVSCode.Models.Commons;
using Inscripciones.Models;
using InstitutoDesktop.Interfaces;
using InstitutoDesktop.Models.MesasExamenes;
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

namespace InstitutoDesktop.Views.MesasExamenes
{
    public partial class AgregarEditarTurnoExamenesView : Form
    {
        IGenericService<TurnoExamen> turnoexamenesService = new GenericService<TurnoExamen>();
        private TurnoExamen turnoexamen;
        public AgregarEditarTurnoExamenesView()
        {
            InitializeComponent();
            turnoexamen = new TurnoExamen();
        }
        public AgregarEditarTurnoExamenesView(TurnoExamen turnoexamen)
        {
            InitializeComponent();
            this.turnoexamen = turnoexamen;
            CargarDatosEnPantalla();
        }
        private async void CargarDatosEnPantalla()
        {
            txtNombre.Text = turnoexamen.Nombre;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            turnoexamen.Nombre = txtNombre.Text;

            if (turnoexamen.Id == 0)
            {
                await turnoexamenesService.AddAsync(turnoexamen);

            }
            else
            {
                await turnoexamenesService.UpdateAsync(turnoexamen);
            }

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
