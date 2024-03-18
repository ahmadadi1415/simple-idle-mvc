using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Agate.MVC.Base;

namespace SimpleIdle.Module.CharsData
{

    public class CharsDataController : DataController<CharsDataController, CharsDataModel, ICharsDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        private void LoadData()
        {
            CharCollection charCollection = new();
            List<CharData> charData = new()
            {
                new CharData("Hank", "Anger issue", 31),
                new CharData("You", "A mere human", 21),
                new CharData("Emma", "Woman", 34),
                new CharData("Hank", "Anger issue", 31),
                new CharData("You", "A mere human", 21),
                new CharData("Emma", "Woman", 34),
                new CharData("Hank", "Anger issue", 31),
                new CharData("You", "A mere human", 21),
            };
            charCollection.chars = charData;
            _model.SetCharsData(charCollection);
        }
    }
}