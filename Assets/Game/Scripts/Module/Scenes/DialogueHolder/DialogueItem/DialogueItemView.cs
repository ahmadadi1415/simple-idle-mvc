using Agate.MVC.Base;
using TMPro;
using UnityEngine;

namespace SimpleIdle.Module.Dialogue
{
    public class DialogueItemView : ObjectView<IDialogueItemModel>
    {
        [SerializeField] private TextMeshProUGUI charNameText, dialogueText;

        protected override void InitRenderModel(IDialogueItemModel model)
        {
            charNameText.text = model.DialogueData.charName;
            dialogueText.text = model.DialogueData.dialogue;
        }

        protected override void UpdateRenderModel(IDialogueItemModel model)
        {
            charNameText.text = model.DialogueData.charName;
            dialogueText.text = model.DialogueData.dialogue;
        }
    }
}