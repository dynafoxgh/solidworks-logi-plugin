namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class ExtrudedBossBase : BasicSolidWorksAction
    {
        public ExtrudedBossBase()
            : base("Extruded Boss/Base", "Create an extruded boss/base", "Sketch Tools", swCommands_e.swCommands_ExtrudedBossBase)
        {
        }
    }
}