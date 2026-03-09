namespace Loupedeck.SolidWorksPlugin
{
    public class CornerRectangle : BasicSolidWorksAction
    {
        public CornerRectangle()
            : base("Corner Rectangle", "Create a corner rectangle", "Sketch Tools", swCommands_e.swCommands_Rectangle)
        {
        }
    }
}