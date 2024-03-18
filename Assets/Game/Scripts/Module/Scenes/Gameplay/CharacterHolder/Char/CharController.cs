using Agate.MVC.Base;
using SimpleIdle.Gameplay.Resource;
using SimpleIdle.Message;

namespace SimpleIdle.Gameplay.Character
{
    public class CharController : ObjectController<CharController, CharModel, ICharModel, CharView>
    {
        private ResourceController _resource;
        public override void SetView(CharView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickEatButton, OnClickDrinkButton);
            view.SetAttributeCallbacks(IncreaseHunger, IncreaseThirst, ReduceStamina);
        }

        public void Init(CharModel model, CharView view)
        {
            _model = model;
            SetView(view);
        }

        private void OnClickEatButton()
        {
            Publish<ResourceConsumedMessage>(new ResourceConsumedMessage("food"));
            Eat();
        }

        private void OnClickDrinkButton()
        {
            Publish<ResourceConsumedMessage>(new ResourceConsumedMessage("water"));
            Drink();
        }

        private void Eat()
        {
            _model.ReduceHunger(_resource.Model.Food.HungerRecovered);
            _model.AddStamina(_resource.Model.Food.StaminaRecovered);
        }

        private void Drink()
        {
            _model.ReduceThirst(_resource.Model.Water.ThirstRecovered);
            _model.AddStamina(_resource.Model.Water.StaminaRecovered);
        }

        private void IncreaseHunger()
        {
            _model.IncreaseHunger(1);
        }

        private void IncreaseThirst()
        {
            _model.IncreaseThirst(3);
        }

        private void ReduceStamina()
        {
            _model.ReduceStamina(2);
        }

    }
}