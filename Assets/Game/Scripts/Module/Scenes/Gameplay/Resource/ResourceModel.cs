using Agate.MVC.Base;

namespace SimpleIdle.Gameplay.Resource
{
    public class ResourceModel : BaseModel, IResourceModel
    {
        public FoodModel Food { get; private set; }
        public WaterModel Water { get; private set; }

        public ResourceModel() {
            Food = new();
            Water = new();
        }

        public void SetFoodModelData(int hungerRecovered, int staminaRecovered, int amount)
        {
            Food.HungerRecovered = hungerRecovered;
            Food.StaminaRecovered = staminaRecovered;
            Food.Amount = amount;
            SetDataAsDirty();
        }

        public void SetWaterModelData(int thirstRecovered, int staminaRecovered, int amount)
        {
            Water.ThirstRecovered = thirstRecovered;
            Water.StaminaRecovered = staminaRecovered;
            Water.Amount = amount;
            SetDataAsDirty();
        }

        public void SetFoodAmount(int amount)
        {
            Food.Amount = amount;
            SetDataAsDirty();
        }

        public void SetWaterAmount(int amount)
        {
            Water.Amount = amount;
            SetDataAsDirty();
        }
        
        public void Consume(string resourceType)
        {
            switch (resourceType)
            {
                case "food":
                    // Publish to Eat
                    Food.Amount--;
                    SetDataAsDirty();
                    break;
                case "water":
                    // Publish to Drink
                    Water.Amount--;
                    SetDataAsDirty();
                    break;
                default:
                    break;
            }
        }
    }
}