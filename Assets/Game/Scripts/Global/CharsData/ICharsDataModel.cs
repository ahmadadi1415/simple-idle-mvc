using Agate.MVC.Base;

namespace SimpleIdle.Module.CharsData
{
    public interface ICharsDataModel : IBaseModel
    {
        public CharCollection CharsData { get; }
    }
}