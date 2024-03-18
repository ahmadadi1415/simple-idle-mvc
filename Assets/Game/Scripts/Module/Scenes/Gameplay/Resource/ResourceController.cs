using System.Collections;
using Agate.MVC.Base;

namespace SimpleIdle.Gameplay.Resource
{
    public class ResourceController : ObjectController<ResourceController, ResourceModel, IResourceModel, ResourceView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnResourceConsumed(string resourceType)
        {
            _model.Consume(resourceType);
        }

        private void LoadData()
        {
            _model.SetFoodModelData(10, 10, 100);
            _model.SetWaterModelData(20, 5, 100);
        }
    }
}