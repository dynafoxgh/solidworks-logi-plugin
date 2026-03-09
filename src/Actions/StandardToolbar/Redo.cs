namespace Loupedeck.SolidWorksPlugin
{
    public class Redo : BasicSolidWorksAction
    {
        public Redo()
            : base("Redo", "Redo the last undone action", "Standard Toolbar", swCommands_e.swCommands_Redo)
        {
        }
    }
}