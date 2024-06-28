using AIMA.CSharpLibrary.AgentComponents.Actions.Interface;
using AIMA.CSharpLibrary.AgentComponents.Agent.Base;
using AIMA.CSharpLibrary.AgentComponents.Common;
using AIMA.CSharpLibrary.AgentComponents.Environment.Interface;
using AIMA.CSharpLibrary.AgentComponents.PerformanceMeasures.Base;
using AIMA.CSharpLibrary.AgentComponents.Precepts.Base;
using AIMA.CSharpLibrary.Common.DataStructure;

namespace AIMA.CSharpLibrary.AgentComponents.Actions.Base
{
    /// <summary>
    /// <para>Base(Base) Environment used to represent the domain within which the agent operates.</para>
    ///<para>
    ///Author:Ciaran O'Reilly
    ///</para>
    ///<para>
    ///Author:Mike Stampone
    ///</para>
    ///<para>
    ///Author:Brendan Wood (Bsc. Hons. IT) - Complied C# Implementation - Supplemental
    ///</para>
    ///<para>Date Created: 13 May 2024 - Date Last Updated: 16 June 2024</para>
    /// </summary>
    public abstract partial class BaseAction : BaseDynamicProperties, IAgentAction
    {
        #region Properties
        /// <summary>
        /// Read-Only Property => Return the User Friendly Name of the Agent ActionExecuted
        /// </summary>
        public string ActionName
        {
            get
            {
                return (string)GetAttributeValue(AgentComponentDefaults.ACTION_NAME);
            }
        }
        #endregion
        #region Ctsor
        /// <summary>
        /// Assigned the default user friendly name for the agent action.
        /// </summary>
        /// <param name="name">String Value => Assigned the System Class Name as the user friendly name of the Agents ActionExecuted</param>
        public BaseAction(string name)
        {
            SetDynamicAttributeValue(AgentComponentDefaults.ACTION_NAME, name);
        }
        /// <summary>
        /// Creates a default action which is to do Nothing.
        /// </summary>
        public BaseAction() : this(AgentComponentDefaults.ACTION_NO_OPERATION)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TPrecept"><inheritdoc/></typeparam>
        /// <typeparam name="TAction"><inheritdoc/></typeparam>
        /// <typeparam name="TPerformanceMeasure"><inheritdoc/></typeparam>
        /// <param name="environmentObjects"><inheritdoc/></param>
        /// <param name="agent"><inheritdoc/></param>
        public abstract void ExecuteAction<TPerformanceMeasure, TPrecept, TAction>(
            LinkedDictonarySet<IEnvironmentObject> environmentObjects,
            BaseAgent<TPerformanceMeasure, TPrecept, TAction> agent)
            where TPrecept : BasePrecept, new()
            where TAction : BaseAction, new()
             where TPerformanceMeasure: BasePerformanceMeasure, new() ;
        #endregion
    }
}
