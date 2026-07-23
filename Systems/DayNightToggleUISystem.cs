using Colossal.UI.Binding;
using Game;
using Game.SceneFlow;
using Game.UI;

namespace HelloWorldMod.Systems
{
    public partial class DayNightToggleUISystem : UISystemBase
    {
        private ValueBinding<bool> m_DayNightVisual;

        public override GameMode gameMode => GameMode.Game;

        protected override void OnCreate()
        {
            base.OnCreate();

            AddBinding(m_DayNightVisual = new ValueBinding<bool>(
                Mod.ID, "DayNightVisual", GameManager.instance.settings.gameplay.dayNightVisual));

            AddBinding(new TriggerBinding(Mod.ID, "ToggleDayNightVisual", ToggleDayNightVisual));
        }

        private void ToggleDayNightVisual()
        {
            var gameplay = GameManager.instance.settings.gameplay;
            gameplay.dayNightVisual = !gameplay.dayNightVisual;
            gameplay.ApplyAndSave();
            m_DayNightVisual.Update(gameplay.dayNightVisual);
        }
    }
}
