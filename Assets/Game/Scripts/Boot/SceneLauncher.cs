using Agate.MVC.Base;

namespace SimpleIdle.Boot
{
    public abstract class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
    where TLauncher : SceneLauncher<TLauncher, TView>
    where TView : BaseSceneView
    {

    }
}