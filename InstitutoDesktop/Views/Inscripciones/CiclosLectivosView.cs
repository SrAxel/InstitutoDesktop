using BlazorAppVSCode.Models.Commons;
using Inscripciones.Models.Inscripciones;
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

namespace InstitutoDesktop.Views.Inscripciones
{

    
    public partial class CiclosLectivosView : Form
    {
        IGenericService<CicloLectivo> ciclolectivoService = new GenericService<CicloLectivo>();
        public CiclosLectivosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridCiclosLectivos.DataSource = await ciclolectivoService.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView();
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridCiclosLectivos.CurrentRow.Cells[0].Value;
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView(idEditar);
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridCiclosLectivos.CurrentRow.Cells[0].Value;
            var nombreCicloLectivo = (string)dataGridCiclosLectivos.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {nombreCicloLectivo}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await ciclolectivoService.DeleteAsync(idEliminar);
                await CargarGrilla();
            }
        }
    }
}
