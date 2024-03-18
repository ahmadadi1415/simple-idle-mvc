using Agate.MVC.Base;

namespace SimpleIdle.Gameplay.Character
{
    public interface ICharModel : IBaseModel
    {

        public string Name { get; }
        public int Stamina { get; }
        public int Hunger { get; }
        public int Thirst { get; }
        public int Temperature { get; }

    }
}