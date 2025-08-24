using Verse;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// RimWorld の Mod エントリーポイント。
    /// ModSettings のロードや保存を司る。
    /// </summary>
    public class AAFMod : Mod
    {
        public static AAFModSettings Settings;

        public AAFMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<AAFModSettings>();
        }

        public override string SettingsCategory()
        {
            return "Animal Animation Framework";
        }

        public override void DoSettingsWindowContents(UnityEngine.Rect inRect)
        {
            Settings.DoWindowContents(inRect);
        }
    }
}
