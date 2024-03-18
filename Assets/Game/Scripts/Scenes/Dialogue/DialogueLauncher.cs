using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SimpleIdle.Boot;
using SimpleIdle.Module.Dialogue;

namespace SimpleIdle.Dialogue 
{
    public class DialogueLauncher : SceneLauncher<DialogueLauncher, DialogueView>
    {
        public override string SceneName => "Dialogue";
        private DialogueHolderController _dialogueHolder;

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
            return new IController[]{
                new DialogueHolderController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
            _dialogueHolder.SetView(_view.DialogueHolderView);
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}