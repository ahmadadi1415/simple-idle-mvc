using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SimpleIdle.MainMenu
{
    public class MainMenuView : BaseSceneView {
        [SerializeField] private Button _playButton, _dialogueButton;

        public void SetCallbacks(UnityAction onClickPlayButton, UnityAction onClickDialogueButton) {
            _playButton.onClick.RemoveAllListeners();
            _dialogueButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
            _dialogueButton.onClick.AddListener(onClickDialogueButton);
        }
    }
}