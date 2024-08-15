using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;

using InstitutoDesktop.Views.Commons.Alumnos;

using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Views.AniosCarrera;


namespace InstitutoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }



        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            CarrerasView carrerasView = new CarrerasView();
            carrerasView.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            CiclosLectivosView ciclosLectivosView = new CiclosLectivosView();
            ciclosLectivosView.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = new AlumnosView();
            alumnosView.ShowDialog();
        }
        private void iconDocente_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = new DocentesView();
            docentesView.ShowDialog();

        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            HorasView horariosView = new HorasView();
            horariosView.ShowDialog();
        }

        private void iconMenuItemAniosCarrera_Click(object sender, EventArgs e)
        {
            AniosCarreraView aniosCarreraView = new AniosCarreraView();
            aniosCarreraView.ShowDialog();
            
        }
    }
}
