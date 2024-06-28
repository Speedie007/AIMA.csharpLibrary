﻿using AIMA.CSharpLibrary.AgentComponents.Actions.Base;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.AgentComponents.Sensor.Base;

namespace AIMA.CSharpLibrary.AgentComponents.Events.EventsArguments.Base
{

    /// <summary>
    /// 18 June
    /// </summary>
    public partial class BaseSensorEventEventArgs<TPerformanceMeasure, TPrecept, TAction> : EventArgs
        where TPrecept : BasePrecept, new()
        where TAction : BaseAction, new()
        where TPerformanceMeasure : BasePerformanceMeasure, new()
    {

        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sensor"></param>
        public BaseSensorEventEventArgs(BaseSensor<TPerformanceMeasure, TPrecept, TAction> sensor)
        {
            Sensor = sensor;
        }
        /// <value>
        /// 
        /// </value>
        public BaseSensor<TPerformanceMeasure, TPrecept, TAction> Sensor { get; }
        #endregion
    }
}
