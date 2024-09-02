﻿using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.ExtensionMethods;
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

namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    public partial class AnioCarreraView : Form
    {
        GenericService<Carrera> carreraService = new GenericService<Carrera>();
        AnioCarreraService anioCarreraService = new AnioCarreraService();
        BindingSource listaAniosCarrera = new BindingSource();
        BindingSource listaCarreras = new BindingSource();
        public AnioCarreraView()
        {
            InitializeComponent();
            dataGridAniosCarrera.DataSource = listaAniosCarrera;
            cboCarreras.DataSource = listaCarreras;
            CargarCboCarreras();
            CargarDatosGrilla();
        }

        private async void CargarDatosGrilla()
        {
            if (cboCarreras.SelectedValue != null && cboCarreras.SelectedValue.GetType() == typeof(int))
            {
                var idCarrera = (int)cboCarreras.SelectedValue;
                listaAniosCarrera.DataSource = await anioCarreraService.GetByCarreraAsync(idCarrera);
                dataGridAniosCarrera.OcultarColumnas(new string[] { "Carrera", "CarreraId", "AñoYCarrera" });
                dataGridAniosCarrera.EstablecerAnchoDeColumnas(new int[] { 100, 300 });
            }
        }

        private async void CargarCboCarreras()
        {
            listaCarreras.DataSource = await carreraService.GetAllAsync();
            cboCarreras.DisplayMember = "Nombre";
            cboCarreras.ValueMember = "Id";
            CargarDatosGrilla();
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(carrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            CargarDatosGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)listaAniosCarrera.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(anioCarrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            CargarDatosGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)listaAniosCarrera.Current;
            var respuesta = MessageBox.Show($"¿Está seguro/a que quiere borrar el Año {anioCarrera.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await anioCarreraService.DeleteAsync(anioCarrera.Id);
                CargarDatosGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
