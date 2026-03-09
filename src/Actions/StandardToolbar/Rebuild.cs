namespace Loupedeck.SolidWorksPlugin
{
    public class Rebuild : BasicSolidWorksAction
    {
        public Rebuild()
            : base("Rebuild", "Rebuild the model", "Standard Toolbar", swCommands_e.swCommands_Rebuild)
        {
        }
    }
}