using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.AniosCarrera
{
    public partial class AniosCarreraView : Form
    {
        AniosCarreraService aniosCarreraService;
        BindingSource listaAniosCarrera;
        public AniosCarreraView()
        {
            InitializeComponent();
            dataGridAniosCarrera.DataSource = listaAniosCarrera;
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            listaAniosCarrera.DataSource = await aniosCarreraService.GetByCarreraAsync();
        }
    }
}
