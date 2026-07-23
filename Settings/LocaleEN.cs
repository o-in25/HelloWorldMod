using System.Collections.Generic;
using Colossal;

namespace HelloWorldMod.Settings
{
    public class LocaleEN : IDictionarySource
    {
        private readonly Settings m_Setting;

        public LocaleEN(Settings setting)
        {
            m_Setting = setting;
        }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Hello World Mod" },
                { m_Setting.GetOptionTabLocaleID(Settings.kAboutSection), "About" },
                { m_Setting.GetOptionGroupLocaleID(Settings.kAboutSection), "About" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Settings.Version)), "Version" },
                { m_Setting.GetOptionDescLocaleID(nameof(Settings.Version)), "The installed version of Hello World Mod." },
            };
        }

        public void Unload()
        {
        }
    }
}
