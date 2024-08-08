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

namespace InstitutoDesktop.Views.Commons
{
    public partial class AgregarEditarCarreraView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        private int idEditar=0;

        public AgregarEditarCarreraView()
        {
            InitializeComponent();
        }

        public AgregarEditarCarreraView(int idEditar)
        {
            InitializeComponent();
            this.idEditar = idEditar;
            CargarDatosCarreraAEditar();
        }

        private async void CargarDatosCarreraAEditar()
        {
            var carrera=await carreraService.GetByIdAsync(idEditar);
            if (carrera != null)
            {
                txtNombre.Text = carrera.Nombre;
                txtSigla.Text = carrera.Sigla;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                var carrera = new Carrera() { Nombre = txtNombre.Text, Sigla = txtSigla.Text };
                await carreraService.AddAsync(carrera);
            }
            else
            {
                var carrera = new Carrera() { Id=idEditar, Nombre = txtNombre.Text, Sigla = txtSigla.Text };
                await carreraService.UpdateAsync(carrera);
            }

            this.Close();
        }
    }
}
