namespace AIMA.CSharpLibrary.Probability
{

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
