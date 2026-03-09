namespace Loupedeck.SolidWorksPlugin
{
    public class Line : BasicSolidWorksAction
    {
        public Line()
            : base("Line", "Create a line", "Sketch Tools", swCommands_e.swCommands_Line)
        {
        }
    }
}