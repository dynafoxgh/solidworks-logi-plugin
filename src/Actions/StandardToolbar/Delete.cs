namespace Loupedeck.SolidWorksPlugin
{
    public class Delete : BasicSolidWorksAction
    {
        public Delete()
            : base("Delete", "Delete the selected entity", "Standard Toolbar", swCommands_e.swCommands_Delete)
        {
        }
    }
}