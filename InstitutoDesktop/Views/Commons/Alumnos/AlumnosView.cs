using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.Services;
using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Commons.Alumnos
{
    public partial class AlumnosView : Form
    {
        IGenericService<Alumno> alumnoService = new GenericService<Alumno>();
        public AlumnosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridAlumnos.DataSource = await alumnoService.GetAllAsync();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarAlumnosView agregarEditarAlumnosView = new AgregarEditarAlumnosView();
            agregarEditarAlumnosView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridAlumnos.CurrentRow.Cells[0].Value;
            var nombreAlumno = (string)dataGridAlumnos.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a el alumno {nombreAlumno}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await alumnoService.DeleteAsync(idEliminar);
                await CargarGrilla();
            }
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridAlumnos.CurrentRow.Cells[0].Value;
            AgregarEditarAlumnosView agregarEditarAlumnosView = new AgregarEditarAlumnosView(idEditar);
            agregarEditarAlumnosView.ShowDialog();
            await CargarGrilla();
        }
    }
}
