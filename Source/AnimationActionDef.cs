using Verse;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// アニメーションの種類や開始条件を定義する Def。
    /// </summary>
    public class AnimationActionDef : Def
    {
        public string actionType;    // Idle / Sleep / Attack など
        public float chance;         // 発生確率
        public int delayTicks;       // 遅延時間
    }
}
