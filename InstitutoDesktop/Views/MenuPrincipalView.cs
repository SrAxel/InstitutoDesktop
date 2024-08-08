using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Commons;

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

        private void iconDocente_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = new DocentesView();
            docentesView.ShowDialog();
        }
    }
}
