namespace Loupedeck.SolidWorksPlugin
{
    public class Undo : BasicSolidWorksAction
    {
        public Undo()
            : base("Undo", "Undo the last action", "Standard Toolbar", swCommands_e.swCommands_Undo)
        {
        }
    }
}