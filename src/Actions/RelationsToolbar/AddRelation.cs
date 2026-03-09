namespace Loupedeck.SolidWorksPlugin
{
    public class AddRelation : BasicSolidWorksAction
    {
        public AddRelation()
            : base("Add Relation", "Add a relation", "Relations Toolbar", swCommands_e.swCommands_AddRelation)
        {
        }
    }
}