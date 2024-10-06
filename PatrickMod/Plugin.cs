using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace PatrickMod
{
    [BepInPlugin("com.archiverxp.patrickmod", "PatrickMod", MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {"com.archiverxp.patrickmod"} is loaded!");
            var harmony = new Harmony("com.archiverxp.patrickmod");
            harmony.PatchAll();
        }
    }
}
