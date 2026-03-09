namespace Loupedeck.SolidWorksPlugin
{
    public class ExtrudedCut : BasicSolidWorksAction
    {
        public ExtrudedCut()
            : base("Extruded Cut", "Create an extruded cut", "Features Toolbar", swCommands_e.swCommands_ExtrudedCut)
        {
        }
    }
}