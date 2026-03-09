namespace Loupedeck.SolidWorksPlugin
{
    public class Ok : BasicSolidWorksAction
    {
        public Ok()
            : base("Ok", "Accept the current dialog", "Standard Toolbar", swCommands_e.swCommands_Ok)
        {
        }
    }

    public class Cancel : BasicSolidWorksAction
    {
        public Cancel()
            : base("Cancel", "Cancel the current dialog", "Standard Toolbar", swCommands_e.swCommands_Cancel)
        {
        }
    }
}