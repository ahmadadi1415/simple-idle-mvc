using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SimpleIdle.Module.CharsData;

namespace SimpleIdle.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[] {
                new CharsDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}