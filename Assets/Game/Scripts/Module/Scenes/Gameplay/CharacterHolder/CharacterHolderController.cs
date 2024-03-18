using System.Collections.Generic;
using Agate.MVC.Base;
using SimpleIdle.Gameplay.Character;
using SimpleIdle.Module.CharsData;
using UnityEngine;

namespace SimpleIdle.Gameplay.CharacterHolder
{
    public class CharacterHolderController : ObjectController<CharacterHolderController, CharacterHolderView>
    {
        private CharsDataController _charsData;
        public override void SetView(CharacterHolderView view)
        {
            base.SetView(view);
            CreateCharacterItem(_charsData.Model.CharsData.chars);
        }

        private void CreateCharacterItem(List<CharData> charDatas) {
            foreach (CharData charData in charDatas){
                GameObject charItemObject = _view.CreateItemObject(charData.name);
                CharModel charItemModel = new CharModel();
                charItemModel.SetName(charData.name);
                CharView charItemView = charItemObject.GetComponent<CharView>();
                CharController charController = new CharController();
                InjectDependencies(charController);
                charController.Init(charItemModel, charItemView);
            }
        }
    }
}