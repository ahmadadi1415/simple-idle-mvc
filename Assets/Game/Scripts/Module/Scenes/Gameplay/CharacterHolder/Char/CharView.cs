using Agate.MVC.Base;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SimpleIdle.Gameplay.Character
{
    public class CharView : ObjectView<ICharModel>
    {
        [SerializeField] private Button _eatButton, _drinkButton;
        [SerializeField] private TextMeshProUGUI _charNameText, _hungerText, _thirstText, _staminaText, _temperatureText;
        private UnityAction _increaseHunger, _increaseThirst, _decreaseStamina;
        private readonly float hungerReductionTime = 1.0f;
        private float timeUntilReduction = 1.0f;

        protected override void InitRenderModel(ICharModel model)
        {
            _charNameText.text = $"{model.Name}";
            _hungerText.text = $"Hunger \t: {model.Hunger}";
            _thirstText.text = $"Thirsty \t: {model.Thirst}";
            _staminaText.text = $"Stamina \t: {model.Stamina}";
            _temperatureText.text = $"Temperature: {model.Temperature}";
        }

        protected override void UpdateRenderModel(ICharModel model)
        {
            _charNameText.text = $"{model.Name}";
            _hungerText.text = $"Hunger \t: {model.Hunger}";
            _thirstText.text = $"Thirsty \t: {model.Thirst}";
            _staminaText.text = $"Stamina \t: {model.Stamina}";
            _temperatureText.text = $"Temperature: {model.Temperature}";
        }

        public void SetCallbacks(UnityAction onClickEatButton, UnityAction onClickDrinkButton)
        {
            _eatButton.onClick.RemoveAllListeners();
            _drinkButton.onClick.RemoveAllListeners();
            _eatButton.onClick.AddListener(onClickEatButton);
            _drinkButton.onClick.AddListener(onClickDrinkButton);
        }

        public void SetAttributeCallbacks(UnityAction increaseHunger, UnityAction increaseThirst, UnityAction decreaseStamina)
        {
            _increaseHunger = increaseHunger;
            _increaseThirst = increaseThirst;
            _decreaseStamina = decreaseStamina;
        }
        
        private void Update() {
            timeUntilReduction -= Time.deltaTime;    
            if (timeUntilReduction <= 0.0f)
            {
                _increaseHunger?.Invoke();
                _increaseThirst?.Invoke();
                _decreaseStamina?.Invoke();
                timeUntilReduction = hungerReductionTime;
            }
        }
    }
}