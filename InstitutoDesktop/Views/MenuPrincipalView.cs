using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;

using InstitutoDesktop.Views.Commons.Alumnos;

using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Views.Commons.AnioCarreras;
using InstitutoDesktop.Views.Commons.Materias;



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

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            AnioCarreraView anioCarreraView = new AnioCarreraView();
            anioCarreraView.ShowDialog();
        }

        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            MateriaView materiaView = new MateriaView();
            materiaView.ShowDialog();
        }

        private void iconMenuItemAniosCarrera_Click(object sender, EventArgs e)
        {
            AniosCarreraView aniosCarreraView = new AniosCarreraView();
            aniosCarreraView.ShowDialog();
            
        }
    }
}
