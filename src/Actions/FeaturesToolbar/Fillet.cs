namespace Loupedeck.SolidWorksPlugin
{
    public class Fillet : BasicSolidWorksAction
    {
        public Fillet()
            : base("Fillet", "Create a fillet", "Features Toolbar", swCommands_e.swCommands_Fillet)
        {
        }
    }
}