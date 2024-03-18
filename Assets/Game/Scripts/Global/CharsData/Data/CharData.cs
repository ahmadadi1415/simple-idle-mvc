namespace SimpleIdle.Module.CharsData
{
    [System.Serializable]
    public class CharData
    {
        public string name;
        public string personality;
        public int age;

        public CharData() { }

        public CharData (string name, string personality, int age)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
        }
    }
}