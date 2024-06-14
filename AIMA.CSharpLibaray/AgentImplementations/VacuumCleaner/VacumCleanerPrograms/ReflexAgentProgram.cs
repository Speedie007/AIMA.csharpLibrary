using AIMA.CSharpLibrary.AgentComponents.Agent.Extentsions;
using AIMA.CSharpLibrary.AgentComponents.Agent.Interface;
using AIMA.CSharpLibrary.AgentComponents.AgentProgram;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions;
using AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Precept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.VacumCleanerPrograms
{
    public partial class ReflexAgentProgram : BaseAgentProgram<IAgent<VacuumCleanerPrecept, VacuumCleanerAction>, VacuumCleanerPrecept, VacuumCleanerAction>
    {
        public ReflexAgentProgram():base()
        {
            
        }
        public override void Initialize()
        {
        }

        public override VacuumCleanerAction ProcessAgentPecept(VacuumCleanerPrecept percept)
        {
            return null;// (VacuumCleanerAction)ActionExtentions.GetNoOperationAction();
        }
    }
}
