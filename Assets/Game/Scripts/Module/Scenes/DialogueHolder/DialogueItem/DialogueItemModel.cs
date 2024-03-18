using System.Collections.Generic;
using Agate.MVC.Base;
using SimpleIdle.Module.Dialogue.Data;

namespace SimpleIdle.Module.Dialogue
{
    public class DialogueItemModel : BaseModel, IDialogueItemModel
    {
        public DialogueData DialogueData { get; private set; }

        public DialogueItemModel()
        {
            DialogueData = new();
        }
        public DialogueItemModel(DialogueData dialogueData)
        {
            DialogueData = new();
            DialogueData = dialogueData;
            SetDataAsDirty();
        }

        public DialogueItemModel(string charName, string dialogueText)
        {
            DialogueData.SetDialogueData(charName, dialogueText);
            SetDataAsDirty();
        }

        public void SetDialogueData(DialogueData dialogueData)
        {
            DialogueData.SetDialogueData(dialogueData.charName, dialogueData.dialogue);
            SetDataAsDirty();
        }

        public void SetDialogueData(string charName, string dialogueText)
        {
            DialogueData.SetDialogueData(charName, dialogueText);
            SetDataAsDirty();
        }
    }
}