namespace Loupedeck.SolidWorksPlugin
{
    public class SmartDimension : BasicSolidWorksAction
    {
        public SmartDimension()
            : base(displayName: "Smart Dimension", description: "Create a smart dimension", groupName: "Sketch Tools", swCommands_e.swCommands_SmartDimension)
        {
        }
    }
}