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
        private Docente docente;
        public AgregarEditarDocenteView()
        {
            InitializeComponent();
            docente = new Docente();
        }


        public AgregarEditarDocenteView(Docente docente)
        {
            InitializeComponent();
            this.docente = docente;
            CargarDatosDocenteAEditar();
        }

        private async void CargarDatosDocenteAEditar()
        {
           
            
                txtNombre.Text = docente.Nombre;
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            docente.Nombre= txtNombre.Text;

            if (docente.Id == 0)
            {
                await docenteService.AddAsync(docente);
            }
            else
            {
                await docenteService.UpdateAsync(docente);
            }

            this.Close();
        }
    }
}
