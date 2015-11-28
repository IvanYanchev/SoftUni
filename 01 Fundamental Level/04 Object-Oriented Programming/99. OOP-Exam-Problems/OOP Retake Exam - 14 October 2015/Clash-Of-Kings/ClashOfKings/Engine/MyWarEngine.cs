using System;
using ClashOfKings.Contracts;
using ClashOfKings.Exceptions;

namespace ClashOfKings.Engine
{
    public class MyWarEngine : WarEngine
    {
        public MyWarEngine(IRenderer renderer, IInputController inputController, IUnitFactory unitFactory, IArmyStructureFactory armyStructureFactory, ICommandFactory commandFactory, IContinent continent) 
            : base(renderer, inputController, unitFactory, armyStructureFactory, commandFactory, continent)
        {

        }

        public override void Run()
        {
            base.Run();
        }
    }
}
