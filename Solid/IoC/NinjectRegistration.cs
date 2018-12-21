using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.IoC
{
    class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sward>();
        }
    }
}
