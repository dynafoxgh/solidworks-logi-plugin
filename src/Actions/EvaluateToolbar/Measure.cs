namespace Loupedeck.SolidWorksPlugin
{
    public class Measure : BasicSolidWorksAction
    {
        public Measure()
            : base("Measure", "Measure entities", "Evaluate Toolbar", swCommands_e.swCommands_Measure)
        {
        }
    }
}