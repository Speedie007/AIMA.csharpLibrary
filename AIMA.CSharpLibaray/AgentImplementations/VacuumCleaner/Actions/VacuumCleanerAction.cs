using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    public partial class VacuumCleanerAction : BaseAgentAction, IVacuumCleanerAction
    {
        public VacuumCleanerAction() : base()
        {
        }

        public VacuumCleanerAction(string name) : base(name)
        {
        }

        public override Type DynamicAtrributeType()
        {
            return GetType();
        }
    }
}
