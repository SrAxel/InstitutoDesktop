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
    public partial class AgregarEditarDocenteView : Form
    {
        IGenericService<Docente> docenteService = new GenericService<Docente>();
        private int idEditar = 0;

        public AgregarEditarDocenteView()
        {
            InitializeComponent();
        }


        public AgregarEditarDocenteView(int idEditar)
        {
            InitializeComponent();
            this.idEditar = idEditar;
            CargarDatosDocenteAEditar();
        }

        private async void CargarDatosDocenteAEditar()
        {
            var docente = await docenteService.GetByIdAsync(idEditar);
            if (docente != null)
            {
                txtNombre.Text = docente.Nombre;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                var docente = new Docente() { Nombre = txtNombre.Text};
                await docenteService.AddAsync(docente);
            }
            else
            {
                var docente = new Docente() { Id = idEditar, Nombre = txtNombre.Text };
                await docenteService.UpdateAsync(docente);
            }

            this.Close();
        }
    }
}
