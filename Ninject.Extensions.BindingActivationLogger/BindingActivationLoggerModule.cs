using System;
using log4net;
using Ninject.Extensions.Logging;

namespace Ninject.Extensions.BindingActivationLogger
{
    using Ninject.Activation.Strategies;
    using Ninject.Modules;

    /// <summary>
    /// Module for loading the binding activation logger
    /// </summary>
    public class BindingActivationLoggerModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Kernel.Components.Add<IActivationStrategy, BindingActivationLogger>();
        }
    }
}