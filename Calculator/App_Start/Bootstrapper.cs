﻿using Prism.Unity;
using System.Windows;
using Unity;
using Calculator.Views;
using System.ComponentModel;
using Calculator.Core.Helpers;
using System.Configuration;

namespace Calculator.App_Start
{
    public class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container = Container
                .RegisterSingletons()
                .RegisterInstances();
        }





    }
}
