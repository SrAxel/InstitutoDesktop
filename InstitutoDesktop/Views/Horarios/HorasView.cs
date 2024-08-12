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

namespace InstitutoDesktop.Views.Horarios
{
    public partial class HorasView : Form
    {
        IGenericService<Hora> horarioService = new GenericService<Hora>();
        public HorasView()
        {
            InitializeComponent();
            CargarGrilla();
        }
        private async Task CargarGrilla()
        {
            dataGridHoras.DataSource = await horarioService.GetAllAsync();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarHoraView agregarEditarHora = new AgregarEditarHoraView();
            agregarEditarHora.ShowDialog();
            CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridHoras.CurrentRow.Cells[0].Value;
            AgregarEditarHoraView agregarEditarHoraView = new AgregarEditarHoraView(idEditar);
            agregarEditarHoraView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridHoras.CurrentRow.Cells[0].Value;
            var nombreHora = (string)dataGridHoras.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a la carrera {nombreHora}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await horarioService.DeleteAsync(idEliminar);
                await CargarGrilla();
            }
        }
    }
}
