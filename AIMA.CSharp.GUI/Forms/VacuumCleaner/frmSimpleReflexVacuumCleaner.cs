using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
