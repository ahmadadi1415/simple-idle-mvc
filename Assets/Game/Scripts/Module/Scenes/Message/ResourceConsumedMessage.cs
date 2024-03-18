namespace SimpleIdle.Message
{
    public struct ResourceConsumedMessage
    {
        public string ResourceType { get; private set; }
        public ResourceConsumedMessage(string resourceType)
        {
            ResourceType = resourceType;
        }
    }
}