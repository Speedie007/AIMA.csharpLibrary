using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    public partial class frmSimpleReflexVacuumCleaner : BaseForm
    {
        public frmSimpleReflexVacuumCleaner(IEnviromentFactory enviromentFactory)//:base(enviromentFactory)
        {
            InitializeComponent();
        }

        private void frmSimpleReflexVacuumCleaner_Load(object sender, EventArgs e)
        {

        }
    }
}
