namespace Loupedeck.SolidWorksPlugin.Helpers
{
    using SolidWorks.Interop.sldworks;

    using System.Diagnostics;
    /// <summary>
    /// Provides helper methods for acquiring a SolidWorks COM application instance.
    /// </summary>
    public static class SolidWorksConnector
    {
        /// <summary>
        /// Attempts to return a running instance of the SolidWorks application.
        /// </summary>
        /// <param name="swApp">Out parameter containing the application if successful.</param>
        /// <returns>True if SolidWorks was found/is running; otherwise false.</returns>
        public static Boolean TryGetApplication(out SldWorks swApp)
        {
            swApp = null;

            if (!OperatingSystem.IsWindows())
            { Console.WriteLine("SolidWorks is only supported on Windows."); return false; }

            if (Process.GetProcessesByName("SLDWORKS").Length == 0)
            { return false; }

            try
            {
                swApp = (SldWorks)Activator.CreateInstance(
                    Type.GetTypeFromProgID("SldWorks.Application"));

                return swApp != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Attempts to return a running SolidWorks instance and its active document.
        /// </summary>
        /// <param name="swApp">Out parameter containing the application if successful.</param>
        /// <param name="activeDoc">Out parameter containing the active document if successful.</param>
        /// <returns>True when both application and active document are available; otherwise false.</returns>
        public static Boolean TryGetActiveDocument(out SldWorks swApp, out ModelDoc2 activeDoc)
        {
            activeDoc = null;

            if (!TryGetApplication(out swApp) || swApp == null)
            {
                Console.WriteLine("SolidWorks is not running.");
                return false;
            }

            Console.WriteLine("Connected to SolidWorks.");

            activeDoc = swApp.ActiveDoc as ModelDoc2;
            if (activeDoc == null)
            {
                Console.WriteLine("No active document in SolidWorks.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the SolidWorks application instance or throws if it cannot be obtained.
        /// </summary>
        /// <returns>Running <see cref="SldWorks"/> instance.</returns>
        public static SldWorks GetApplicationOrThrow()
        {
            return !TryGetApplication(out var swApp) || swApp == null
                ? throw new InvalidOperationException("SolidWorks is not running or could not be started.")
                : swApp;
        }
    }
}