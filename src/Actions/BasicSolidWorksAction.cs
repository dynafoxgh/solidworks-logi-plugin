namespace Loupedeck.SolidWorksPlugin;

using Helpers;

public abstract class BasicSolidWorksAction : PluginDynamicCommand
{
    private readonly String _Icon;
    private readonly swCommands_e _Command;
    public BasicSolidWorksAction(String displayName, String description, String groupName, swCommands_e command)
        : base(displayName: displayName,
            description: description,
            groupName: groupName)
    {
        this._Icon = displayName.Replace(" ", "").Replace("/", "");
        this._Command = command;
    }

    protected override void RunCommand(String actionParameter)
    {
        try
        {
            if (!SolidWorksConnector.TryGetActiveDocument(out var swApp, out var model))
            {
                return;
            }

            swApp.CommandInProgress = true;
            this.ExecuteCommand(swApp, model, actionParameter);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            if (SolidWorksConnector.TryGetApplication(out var swApp))
            {
                swApp.CommandInProgress = false;
            }
        }
    }

    protected virtual void ExecuteCommand(SldWorks swApp, ModelDoc2 activeDoc, String actionParameter)
        => swApp.RunCommand((Int32)this._Command, ""); // Run the SolidWorks command.

    protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        => BitmapImage.FromResource(this.Plugin.Assembly, $"Loupedeck.SolidWorksPlugin.{this._Icon}.png");
}
