using ChessApp.BusinessLogic;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.IoC
{
    public class ChessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameplay>().To<Gameplay>().InSingletonScope();
            Bind<IRuleService>().To<RuleService>().InSingletonScope();
        }
    }
}
