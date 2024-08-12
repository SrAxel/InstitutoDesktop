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

namespace InstitutoDesktop.Views.Horarios
{
    public partial class AgregarEditarHoraView : Form
    {
        IGenericService<Hora> horarioService = new GenericService<Hora>();
        private int idEditar=0;

        public AgregarEditarHoraView()
        {
            InitializeComponent();
        }

        public AgregarEditarHoraView(int idEditar)
        {
            InitializeComponent();
            this.idEditar = idEditar;
            CargarDatosEnPantalla();
        }

        private async void CargarDatosEnPantalla()
        {
            var hora = await horarioService.GetByIdAsync(idEditar);
            txtNombre.Text = hora.Nombre;
            chkRecreo.Checked = hora.esRecreo;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar == 0)
            {
                var hora = new Hora()
                {
                    Nombre = txtNombre.Text,
                    esRecreo = chkRecreo.Checked
                };
                await horarioService.AddAsync(hora);
            }
            else
            {
                var hora = new Hora()
                {
                    Id = idEditar,
                    Nombre = txtNombre.Text,
                    esRecreo = chkRecreo.Checked
                };
                await horarioService.UpdateAsync(hora);
            }
           
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
