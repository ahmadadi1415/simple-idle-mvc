using System.Collections.Generic;
using Agate.MVC.Base;
using SimpleIdle.Module.Dialogue.Data;

namespace SimpleIdle.Module.Dialogue
{
    public interface IDialogueItemModel : IBaseModel
    {
        public DialogueData DialogueData { get; }
    }
}