using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using SimpleIdle.Boot;
using SimpleIdle.Module.Dialogue.Data;
using Unity.VisualScripting;
using UnityEngine;

namespace SimpleIdle.Module.Dialogue
{
    public class DialogueHolderController : ObjectController<DialogueHolderController, DialogueHolderModel, IDialogueHolderModel, DialogueHolderView>
    {
        private List<DialogueData> dialogueDatas;
        private int currentNum = 0;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public override void SetView(DialogueHolderView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickNext, OnClickReturn);
        }

        private void LoadData()
        {
            dialogueDatas = new()
            {
                new("Hank", "Hello!"),
                new("Emma", "Hi"),
                new("You", "How are you? I'am the MC"),
                new("Hank", "Lorem ipsum dolor sit atmet."),
                new("Emma", "Lorem ipsum dolor sit atmet."),
                new("Alex", "Lorem ipsum dolor sit atmet."),
                new("Emma", "Lorem ipsum dolor sit atmet."),
                new("You", "Lorem ipsum dolor sit atmet."),
                new("Hank", "Lorem ipsum dolor sit atmet."),
                new("Alex", "Lorem ipsum dolor sit atmet."),
                new("Hank", "Lorem ipsum dolor sit atmet.")
            };
        }

        private void OnClickNext()
        {
            // Add New Dialogue to DialogueHolderModel
            if (currentNum < dialogueDatas.Count)
            {
                Debug.Log(dialogueDatas[currentNum]);
                CreateDialogueItemView(dialogueDatas[currentNum]);
                currentNum++;
            }
        }

        private void OnClickReturn()
        {
            // Return to MainMenu
            SceneLoader.Instance.LoadScene("MainMenu");
        }

        private void CreateDialogueItemView(DialogueData dialogueData)
        {
            GameObject dialogueItemObject = _view.CreateItemObject("DialogueItem");
            DialogueItemModel dialogueItemModel = new();
            dialogueItemModel.SetDialogueData(dialogueData);
            DialogueItemView dialogueItemView = dialogueItemObject.GetComponent<DialogueItemView>();
            _model.AddDialogueItem(dialogueItemModel);
            dialogueItemView.SetModel(dialogueItemModel);
        }
    }
}