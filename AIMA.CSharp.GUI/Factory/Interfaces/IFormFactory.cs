namespace AIMA.CSharp.GUI.Factory.Interfaces
{
    //https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
   
    /// <summary>
    /// 
    /// </summary>
    public partial interface IFormFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Create<T>() where T : Form;
    }
}
