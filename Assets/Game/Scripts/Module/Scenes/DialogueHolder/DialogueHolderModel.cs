using System.Collections.Generic;
using Agate.MVC.Base;

namespace SimpleIdle.Module.Dialogue
{
    public class DialogueHolderModel : BaseModel, IDialogueHolderModel
    {
        public List<DialogueItemModel> DialogueItems { get; private set; }

        public DialogueHolderModel()
        {
            DialogueItems = new();
            SetDataAsDirty();
        }

        public void AddDialogueItem(DialogueItemModel dialogueItemModel)
        {
            
            DialogueItems.Add(dialogueItemModel);
            SetDataAsDirty();
        }
    }
}