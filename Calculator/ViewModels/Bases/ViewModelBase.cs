using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels.Bases
{
    public abstract class ViewModelBase: BindableBase
    {
        public ViewModelBase()
        {
            RegisterCommands();
        }

        protected virtual void RegisterCommands()
        {
        }
    }
}
