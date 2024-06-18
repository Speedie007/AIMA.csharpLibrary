namespace AIMA.CSharpLibrary.Probability.Interfaces
{
    /// <summary>
    /// 
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
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPercept"></typeparam>
    /// <typeparam name="TAction"></typeparam>
    public partial interface IBeliefState<TPercept, TAction>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="percept"></param>
        void update(TAction action, TPercept percept);
    }
}
