namespace UnofficialTLDPatch
{
    public class Settings : JsonModSettings
    {
        internal static Settings Instance { get; } = new();

        [Name("Fix Natural Foods")]
        [Description("If enabled, this will ensure that natural foods are properly flaged. This mostly affects achievements. This cant be reverted")]
        public bool FixNaturalFoods = false;

        protected override void OnConfirm()
        {
            base.OnConfirm();
        }

        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
        {
            base.OnChange(field, oldValue, newValue);
        }

        internal static void OnLoad()
        {
            Instance.AddToModSettings(BuildInfo.GUIName);
            Instance.RefreshGUI();
        }
    }
}