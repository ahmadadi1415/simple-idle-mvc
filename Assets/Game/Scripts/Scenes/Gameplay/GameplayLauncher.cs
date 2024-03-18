using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SimpleIdle.Boot;
using SimpleIdle.Gameplay.Character;
using SimpleIdle.Gameplay.CharacterHolder;
using SimpleIdle.Gameplay.Resource;

namespace SimpleIdle.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private CharacterHolderController _characterHolder;
        private ResourceController _resource;

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override ISplash GetSplash()
        {
            return SplashScreen.Instance;
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new ResourceConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new CharController(),
                new CharacterHolderController(),
                new ResourceController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
            _characterHolder.SetView(_view.CharacterHolderView);
            _resource.SetView(_view.ResourceView);
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

    }
}