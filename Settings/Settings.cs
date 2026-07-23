using Colossal.IO.AssetDatabase;
using Game.Modding;
using Game.Settings;

namespace HelloWorldMod.Settings
{
    [FileLocation(nameof(HelloWorldMod))]
    public class Settings : ModSetting
    {
        public const string kAboutSection = "About";

        public Settings(IMod mod) : base(mod)
        {
        }

        [SettingsUISection(kAboutSection)]
        public string Version => "1.0";

        public override void SetDefaults()
        {
        }
    }
}
