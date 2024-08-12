using BlazorAppVSCode.Models.Commons;
using Inscripciones.Models.Inscripciones;
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

namespace InstitutoDesktop.Views.Inscripciones
{
    public partial class AgregarEditarCicloLectivoView : Form
    {
        IGenericService<CicloLectivo> ciclolectivoService = new GenericService<CicloLectivo>();
        private int idEditar = 0;
        public AgregarEditarCicloLectivoView()
        {
            InitializeComponent();
        }
        public AgregarEditarCicloLectivoView(int idEditar)
        {
            InitializeComponent();
            this.idEditar = idEditar;
            CargarDatosCicloLectivoAEditar();
        }

        private async void CargarDatosCicloLectivoAEditar()
        {
            var ciclolectivo = await ciclolectivoService.GetByIdAsync(idEditar);
            if (ciclolectivo != null)
            {
                txtNombre.Text = ciclolectivo.Nombre;
               
            }

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                var ciclolectivo = new CicloLectivo() { Nombre = txtNombre.Text };
                await ciclolectivoService.AddAsync(ciclolectivo);
            }
            else
            {
                var ciclolectivo = new CicloLectivo() { Id = idEditar, Nombre = txtNombre.Text };
                await ciclolectivoService.UpdateAsync(ciclolectivo);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
