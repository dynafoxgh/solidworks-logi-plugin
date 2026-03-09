namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class AddRelation : BasicSolidWorksAction
    {
        public AddRelation()
            : base("Add Relation", "Add a relation", "Sketch Tools", swCommands_e.swCommands_AddRelation)
        {
        }
    }
}