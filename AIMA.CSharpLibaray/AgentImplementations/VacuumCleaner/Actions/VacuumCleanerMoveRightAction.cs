using AIMA.CSharpLibrary.Common.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    public class VacuumCleanerMoveRightAction : BaseVacuumCleanerMovementAction
    {
        public VacuumCleanerMoveRightAction() : base(nameof(VacuumCleanerMoveRightAction))
        {

        }

        public override bool CanMoveToNextLocation(XYLocation FromLocation)
        {
            throw new NotImplementedException();
        }

        public override Type DynamicAtrributeType()
        {
            return GetType();
        }

        public override XYLocation GetNextLocation(XYLocation FromLocation)
        {
            throw new NotImplementedException();
        }
    }
}
