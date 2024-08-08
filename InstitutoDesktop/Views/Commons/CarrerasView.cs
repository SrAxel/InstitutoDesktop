using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.Interfaces;
using InstitutoDesktop.Services;
using InstitutoDesktop.Views.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views
{
    public partial class CarrerasView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();

        public CarrerasView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridCarreras.DataSource = await carreraService.GetAllAsync();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCarreraView agregarEditarCarreraView = new AgregarEditarCarreraView();
            agregarEditarCarreraView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridCarreras.CurrentRow.Cells[0].Value;
            var nombreCarrera = (string)dataGridCarreras.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a la carrera {nombreCarrera}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await carreraService.DeleteAsync(idEliminar);
                await CargarGrilla();
            }
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridCarreras.CurrentRow.Cells[0].Value;
            AgregarEditarCarreraView agregarEditarCarreraView = new AgregarEditarCarreraView(idEditar);
            agregarEditarCarreraView.ShowDialog();
            await CargarGrilla();
        }
    }
}
