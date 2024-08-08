using BlazorAppVSCode.Models.Commons;
using InstitutoDesktop.Interfaces;
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

namespace InstitutoDesktop.Views.Commons.Alumnos
{
    public partial class AgregarEditarAlumnosView : Form
    {
        IGenericService<Alumno> alumnoService = new GenericService<Alumno>();
        private int idEditar = 0;

        public AgregarEditarAlumnosView()
        {
            InitializeComponent();
        }

        public AgregarEditarAlumnosView(int idEditar)
        {
            InitializeComponent();
            this.idEditar = idEditar;
            CargarDatosAlumnosAEditar();
        }

        private async void CargarDatosAlumnosAEditar()
        {
            var alumno = await alumnoService.GetByIdAsync(idEditar);
            if (alumno != null)
            {
                txtNombre.Text = alumno.ApellidoNombre;
                txtTelefono.Text = alumno.Telefono;
                txtDireccion.Text = alumno.Direccion;
                txtEmail.Text = alumno.Email;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                var alumno = new Alumno() { ApellidoNombre = txtNombre.Text, Telefono = txtTelefono.Text, Direccion = txtDireccion.Text, Email = txtEmail.Text };
                await alumnoService.AddAsync(alumno);
            }
            else
            {
                var alumno = new Alumno() { Id = idEditar, ApellidoNombre = txtNombre.Text, Telefono = txtTelefono.Text, Direccion = txtDireccion.Text, Email = txtEmail.Text };
                await alumnoService.UpdateAsync(alumno);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
