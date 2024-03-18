namespace SimpleIdle.Module.Dialogue.Data
{
    public class DialogueData
    {
        public string charName;
        public string dialogue;

        public DialogueData() { }

        public DialogueData(string charName, string dialogue)
        {
            this.charName = charName;
            this.dialogue = dialogue;
        }

        public void SetDialogueData(string charName, string dialogue)
        {
            this.charName = charName;
            this.dialogue = dialogue;
        }

    }
}