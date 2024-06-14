namespace AIMA.CSharp.GUI.Factory.Interfaces
{
    //https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
    public partial interface IFormFactory
    {
        T? Create<T>() where T : Form;
    }
}
