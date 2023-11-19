namespace UnofficialTLDPatch
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

        // used to do things when a scene is Initialized. This is called every time this happens, so use this method NOT OnSceneWasLoaded
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            base.OnSceneWasInitialized(buildIndex, sceneName);
        }

        // triggered exclusively when addative scenes are loaded
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
        }

        // triggered when scenes are unloaded
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasUnloaded(buildIndex, sceneName);
        }

        // Use this to do things on update instead of patching GameManger.Update();
        public override void OnLateUpdate()
        {
            base.OnLateUpdate();
        }
    }
}
