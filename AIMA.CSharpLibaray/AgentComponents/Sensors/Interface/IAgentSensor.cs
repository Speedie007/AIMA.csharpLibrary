namespace AIMA.CSharpLibrary.AgentComponents.Sensors.Interface
{
   /// <summary>
   /// 
   /// </summary>
   /// <typeparam name="TPrecpt"></typeparam>
    public partial interface IAgentSensor<TPrecpt>
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        TPrecpt PollEnviromentFunc();
    }
}
