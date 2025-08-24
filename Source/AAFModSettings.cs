using Verse;
using UnityEngine;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// ユーザーが設定できる内容を保持するクラス。
    /// 例: 同時にアニメーションできる上限数など。
    /// </summary>
    public class AAFModSettings : ModSettings
    {
        public bool useAnimationLimit = false;  // チェックボックス
        public int animationLimit = 5;          // 上限数 (0 = 無効)

        public override void ExposeData()
        {
            Scribe_Values.Look(ref useAnimationLimit, "useAnimationLimit", false);
            Scribe_Values.Look(ref animationLimit, "animationLimit", 5);
        }

        public void DoWindowContents(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            list.Begin(inRect);

            list.CheckboxLabeled("同時アニメーション数に上限を設ける", ref useAnimationLimit);
            list.Label("アニメーション上限数 (0 = 無効化): " + animationLimit);
            animationLimit = (int)Widgets.HorizontalSlider(inRect, animationLimit, 0, 20, false, animationLimit.ToString(), "0", "20");

            list.End();
        }
    }
}
