using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharp.GUI.VacuumCleaner
{
    [Designer("System.Windows.Forms.Design.DocumentDesigner, System.Windows.Forms.Design.DLL",
    typeof(IRootDesigner)),
    DesignerCategory("Form")]
    public class crtlTestControl : Button
    {
        public crtlTestControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            // InitializeComponent();
        }

      

        private void InitializeComponent()
        {

        }
    }
}
