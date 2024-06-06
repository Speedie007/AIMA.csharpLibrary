using AIMA.CSharpLibrary.AgentComponents.Sensors.Interface;

namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Base
{
    public partial class BaseSensor<TPrecept>: IAgentSensor<TPrecept>
    {

        #region Cstor
        public BaseSensor()
        {
                
        }


        #endregion

        #region Methods
        public TPrecept PollEnviromentFunc()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
