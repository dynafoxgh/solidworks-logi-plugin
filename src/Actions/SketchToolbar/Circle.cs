namespace Loupedeck.SolidWorksPlugin
{
    public class Circle : BasicSolidWorksAction
    {
        public Circle()
            : base("Circle", "Create a circle", "Sketch Tools", swCommands_e.swCommands_Circle)
        {
        }
    }
}