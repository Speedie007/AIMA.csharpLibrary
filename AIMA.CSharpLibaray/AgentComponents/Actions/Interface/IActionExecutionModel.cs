using AIMA.CSharpLibrary.AgentComponents.Models.Interfaces;

namespace AIMA.CSharpLibrary.AgentComponents.Actions.Interface
{
    /// <summary>
    /// June 24
    /// </summary>
    public partial interface IActionExecutionModel : IModel
    {
       /// <summary>
       /// 
       /// </summary>
        void ExecuteAction();
    }
}
