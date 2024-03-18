using Agate.MVC.Base;
using TMPro;
using UnityEngine;

namespace SimpleIdle.Gameplay.Resource
{
    public class ResourceView : ObjectView<IResourceModel>
    {
        [SerializeField] private TextMeshProUGUI _foodAmountText, _waterAmountText;

        protected override void InitRenderModel(IResourceModel model)
        {
            _foodAmountText.text = $"Food\t: {_model.Food.Amount}";
            _waterAmountText.text = $"Water\t: {_model.Water.Amount}";
        }

        protected override void UpdateRenderModel(IResourceModel model)
        {
            _foodAmountText.text = $"Food\t: {_model.Food.Amount}";
            _waterAmountText.text = $"Water\t: {_model.Water.Amount}";
        }
    }
}