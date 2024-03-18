using System.Collections.Generic;
using Agate.MVC.Base;

namespace SimpleIdle.Module.Dialogue
{
    public interface IDialogueHolderModel : IBaseModel
    {
        public List<DialogueItemModel> DialogueItems { get; }
    }
}