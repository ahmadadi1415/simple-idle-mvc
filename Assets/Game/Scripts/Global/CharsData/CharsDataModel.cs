using Agate.MVC.Base;

namespace SimpleIdle.Module.CharsData
{
    public class CharsDataModel : BaseModel, ICharsDataModel
    {
        public CharCollection CharsData {get; private set;}

        public void SetCharsData(CharCollection charsData)
        {
            CharsData = charsData;
            SetDataAsDirty();
        }
    }
}