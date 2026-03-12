namespace Loupedeck.SolidWorksPlugin
{
    public class EditMaterial : BasicSolidWorksAction
    {
        public EditMaterial()
            : base("Edit Material", "Edit the material of the selected part", "Standard Toolbar", swCommands_e.swCommands_EditMaterial)
        {
        }
    }
}