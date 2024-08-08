using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Commons.Alumnos;

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

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = new AlumnosView();
            alumnosView.ShowDialog();
        }
    }
}
