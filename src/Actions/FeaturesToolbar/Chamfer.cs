namespace Loupedeck.SolidWorksPlugin
{
    public class Chamfer : BasicSolidWorksAction
    {
        public Chamfer()
            : base("Chamfer", "Create a chamfer", "Features Toolbar", swCommands_e.swCommands_Chamfer)
        {
        }
    }
}