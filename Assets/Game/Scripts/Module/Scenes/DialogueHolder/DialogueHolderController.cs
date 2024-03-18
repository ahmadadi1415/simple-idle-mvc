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
            dialogueDatas = new()
            {
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat"),
                new("Hank", "Chat")
            };

        }

        public override void SetView(DialogueHolderView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickNext, OnClickReturn);
        }

        private void OnClickNext()
        {
            // Add New Dialogue to DialogueHolderModel
            if (currentNum < dialogueDatas.Count)
            {
                Debug.Log(dialogueDatas[currentNum]);
                CreateDialogueItemView(dialogueDatas[currentNum]);
                Debug.Log("Test");
                currentNum++;
            }
        }

        private void OnClickReturn()
        {
            // Return to MainMenu
        }

        private void CreateDialogueItemView(DialogueData dialogueData)
        {
            GameObject dialogueItemObject = _view.CreateItemObject("DialogueItem");
            DialogueItemModel dialogueItemModel = new();
            Debug.Log(dialogueItemModel.IsUnityNull());
            dialogueItemModel.SetDialogueData(dialogueData);
            DialogueItemView dialogueItemView = dialogueItemObject.GetComponent<DialogueItemView>();
            _model.AddDialogueItem(dialogueItemModel);
            dialogueItemView.SetModel(dialogueItemModel);
        }
    }
}