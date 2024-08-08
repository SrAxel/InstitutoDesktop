using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.Interfaces;
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

namespace InstitutoDesktop.Views.Commons
{
    public partial class DocentesView : Form
    {
        IGenericService<Docente> docenteService = new GenericService<Docente>();

        public DocentesView()
        {
            InitializeComponent();
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            dataGridDocentes.DataSource = await docenteService.GetAllAsync();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView();
            agregarEditarDocenteView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridDocentes.CurrentRow.Cells[0].Value;
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView(idEditar);
            agregarEditarDocenteView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridDocentes.CurrentRow.Cells[0].Value;
            var nombreDocente = (string)dataGridDocentes.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el docente{nombreDocente}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await docenteService.DeleteAsync(idEliminar);
                await CargarGrilla();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
