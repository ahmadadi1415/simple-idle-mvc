using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SimpleIdle.Boot;

namespace SimpleIdle.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName => "MainMenu";

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
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
            _view.SetCallbacks(OnClickPlayButton, OnClickDialogueButton);

        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }


        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }

        private void OnClickDialogueButton()
        {
            SceneLoader.Instance.LoadScene("Dialogue");
        }
    }
}