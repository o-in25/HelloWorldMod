using Colossal.IO.AssetDatabase;
using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using HelloWorldMod.Systems;

namespace HelloWorldMod
{
    public class Mod : IMod
    {
        public const string ID = nameof(HelloWorldMod);

        public static ILog log = LogManager.GetLogger($"{nameof(HelloWorldMod)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public static Settings.Settings settings;

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info(nameof(OnLoad));

            if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
                log.Info($"Current mod asset at {asset.path}");

            settings = new Settings.Settings(this);
            settings.RegisterInOptionsUI();
            GameManager.instance.localizationManager.AddSource("en-US", new Settings.LocaleEN(settings));
            AssetDatabase.global.LoadSettings(nameof(HelloWorldMod), settings, new Settings.Settings(this));

            updateSystem.UpdateAt<DayNightToggleUISystem>(SystemUpdatePhase.UIUpdate);
        }

        public void OnDispose()
        {
            log.Info(nameof(OnDispose));

            if (settings != null)
            {
                settings.UnregisterInOptionsUI();
                settings = null;
            }
        }
    }
}
