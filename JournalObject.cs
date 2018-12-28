using System;
namespace JournalApp
{
    public class JournalObject
    {
        public string journalMessage = "Hey! We're gonna get started. ";
        private string password = "123";
        private bool Unlocked = false;

        private JournalEntry entry = new JournalEntry();
        public JournalEntry Entry
        {
            get
            {
                if (Unlocked)
                    return entry;
                else
                    return null;
            }
        }
        public bool UnlockJournal(string message)
        {
            if (message == password)
            {
                Unlocked = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LockJournal()
        {
            Unlocked = false;
        }
    }

}
