using Agate.MVC.Base;

namespace SimpleIdle.Gameplay.Resource
{
    public interface IResourceModel : IBaseModel
    {
        public FoodModel Food { get; }
        public WaterModel Water { get; }

    }
    public class FoodModel
    {
        public int StaminaRecovered { get; set; }
        public int HungerRecovered { get; set; }
        public int Amount { get; set; }
    }

    public class WaterModel
    {
        public int StaminaRecovered { get; set; }
        public int ThirstRecovered { get; set; }
        public int Amount { get; set; }
    }
}