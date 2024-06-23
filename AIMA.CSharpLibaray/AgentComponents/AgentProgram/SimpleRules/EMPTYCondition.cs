using AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.AgentComponents.AgentProgram.SimpleRules
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EMPTYCondition : BaseCondition
    {
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        public EMPTYCondition()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="TState"><inheritdoc/></typeparam>
        /// <param name="state"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Validate<TState>(TState state)
        {
            return true;
        }
        #endregion

    }
}
