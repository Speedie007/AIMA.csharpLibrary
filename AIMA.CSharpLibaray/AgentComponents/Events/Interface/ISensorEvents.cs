namespace AIMA.CSharpLibrary.AgentComponents.Events.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrecept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface ISensorEvents<TPrecept,TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        event SensorEventHandlers.SensorInitializedEventHandler<TPrecept, TAction> SensorInitialized;
    }
}
