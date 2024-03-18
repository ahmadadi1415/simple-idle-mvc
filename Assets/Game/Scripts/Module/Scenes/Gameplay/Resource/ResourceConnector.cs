using Agate.MVC.Base;
using SimpleIdle.Message;

namespace SimpleIdle.Gameplay.Resource
{
    public class ResourceConnector : BaseConnector
    {
        private ResourceController _resource;

        protected override void Connect()
        {
            Subscribe<ResourceConsumedMessage>(OnResourceConsumed);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ResourceConsumedMessage>(OnResourceConsumed);
        }

        public void OnResourceConsumed(ResourceConsumedMessage message)
        {
            _resource.OnResourceConsumed(message.ResourceType);
        }
    }
}