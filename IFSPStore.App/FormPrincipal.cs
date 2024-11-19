using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void ExibeFormulario<TFormularioo> where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormularioo>();
            if(cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
