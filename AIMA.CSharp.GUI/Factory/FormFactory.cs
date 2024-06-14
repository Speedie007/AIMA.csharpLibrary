using AIMA.CSharp.GUI.Factory.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharp.GUI.Factory
{
    public partial class FormFactory : IFormFactory
    {
        #region Fields
        private readonly IServiceScope _scope;
        #endregion
        #region Cstor
        public FormFactory(IServiceScopeFactory scopeFactory)
        {
            _scope = scopeFactory.CreateScope();
        }
        #endregion
        public T Create<T>() where T : Form
        {
            return _scope.ServiceProvider.GetService<T>();
        }
    }
}
