namespace AIMA.CSharpLibrary.AgentImplementations.VacuumCleaner.Actions
{
    public class VacuumCleanerSuckAction : VacuumCleanerAction
    {
        public VacuumCleanerSuckAction() : base(nameof(VacuumCleanerSuckAction))
        {

        }

        public override Type DynamicAtrributeType()
        {
            
            return GetType();
        }
    }
}
