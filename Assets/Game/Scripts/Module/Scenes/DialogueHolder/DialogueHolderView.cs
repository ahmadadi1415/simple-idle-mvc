using Agate.MVC.Base;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SimpleIdle.Module.Dialogue
{
    public class DialogueHolderView : ObjectView<IDialogueHolderModel>
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _itemContainer;
        [SerializeField] private Button _nextButton, _returnButton;

        protected override void InitRenderModel(IDialogueHolderModel model)
        {
            foreach (Transform child in _itemContainer)
            {
                Destroy(child.gameObject);
            }
        }

        protected override void UpdateRenderModel(IDialogueHolderModel model)
        {

        }

        public void SetCallbacks(UnityAction onClickNext, UnityAction onClickReturn)
        {
            _nextButton.onClick.RemoveAllListeners();
            _returnButton.onClick.RemoveAllListeners();
            _nextButton.onClick.AddListener(onClickNext);
            _returnButton.onClick.AddListener(onClickReturn);
        }

        public GameObject CreateItemObject(string name)
        {
            GameObject itemObject = GameObject.Instantiate(_prefab, _itemContainer);
            itemObject.name = name;
            itemObject.SetActive(true);
            return itemObject;
        }
    }
}