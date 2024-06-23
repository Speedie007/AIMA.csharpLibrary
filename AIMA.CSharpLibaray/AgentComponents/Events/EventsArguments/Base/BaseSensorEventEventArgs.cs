using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{

    /// <summary>
    /// 18 Jume
    /// </summary>
    public partial class BaseSensorEventEventArgs<TPrecept, TAction> : EventArgs
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sensor"></param>
        public BaseSensorEventEventArgs(BaseSensor<TPrecept, TAction> sensor)
        {
            Sensor = sensor;
        }
        /// <value>
        /// 
        /// </value>
        public BaseSensor<TPrecept, TAction> Sensor { get; }
        #endregion
    }
}
