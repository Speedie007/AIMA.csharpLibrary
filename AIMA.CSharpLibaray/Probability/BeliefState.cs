using AIMA.CSharpLibrary.Probability.Interfaces;

namespace AIMA.CSharpLibrary.Probability
{
    /// <summary>
    /// 18 June
    /// </summary>
    /// <typeparam name="TPercept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial class BeliefState<TPercept, TAction> : IBeliefState<TPercept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public BeliefState() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="percept"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void update(TAction action, TPercept percept)
        {
            throw new NotImplementedException();
        }
    }
}
