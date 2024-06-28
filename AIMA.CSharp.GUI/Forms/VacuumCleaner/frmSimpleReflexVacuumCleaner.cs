using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;

namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmSimpleReflexVacuumCleaner : BaseForm
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enviromentFactory"></param>
        public frmSimpleReflexVacuumCleaner(IEnvironmentFactory enviromentFactory)//:base(enviromentFactory)
        {
            InitializeComponent();
        }

        private void frmSimpleReflexVacuumCleaner_Load(object sender, EventArgs e)
        {

        }
    }
}
