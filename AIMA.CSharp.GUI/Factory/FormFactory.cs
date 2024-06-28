using AIMA.CSharp.GUI.Factory.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AIMA.CSharp.GUI.Factory
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormFactory : IFormFactory
    {
        #region Fields
        private readonly IServiceScope _scope;
        #endregion
        #region Cstor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scopeFactory"></param>
        public FormFactory(IServiceScopeFactory scopeFactory)
        {
            _scope = scopeFactory.CreateScope();
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Create<T>() where T : Form
        {
            return _scope.ServiceProvider?.GetService<T>();
        }
    }
}
