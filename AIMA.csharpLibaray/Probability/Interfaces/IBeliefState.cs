using AIMA.csharpLibrary.AgentProgram.Agent.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.csharpLibrary.Probability.Interfaces
{
    public partial class BeliefState<TPercept, TAction> : IBeliefState<TPercept, TAction>
    {
        public BeliefState() { }
        public void update(TAction action, TPercept percept)
        {
            throw new NotImplementedException();
        }
    }
    public partial interface IBeliefState<TPercept, TAction>
    {
        void update(TAction action, TPercept percept);
    }
}
