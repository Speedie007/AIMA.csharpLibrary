using AIMA.CSharpLibrary.AgentComponents.Agent;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    
    public class VacuumCleanerMoveUpAction : BaseVacuumCleanerMovementAction
    {
        public VacuumCleanerMoveUpAction() : base(nameof(VacuumCleanerMoveUpAction))
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

        public override XYLocation GetNextLocation(XYLocation currentLocation)
        {
            throw new NotImplementedException();
        }
    }

    

    

   
   
}
