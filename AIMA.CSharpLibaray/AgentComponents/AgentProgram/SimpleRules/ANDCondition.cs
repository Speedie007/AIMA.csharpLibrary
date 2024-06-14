using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    public partial class ANDCondition : Condition
    {
        #region Properties
        public Condition LeftCondition { get; private set; }
        public Condition RightCondition { get; private set; }
        #endregion
        #region Cstor
        public ANDCondition(Condition leftCondition, Condition rightConditoin)
        {
            LeftCondition = leftCondition;
            RightCondition = rightConditoin;
        }
        #endregion
    }
}
