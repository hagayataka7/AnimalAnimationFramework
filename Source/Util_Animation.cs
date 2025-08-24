using Verse;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// 汎用的なアニメーション関連ユーティリティ。
    /// </summary>
    public static class Util_Animation
    {
        public static CompAnimated TryGetCompAnimated(Pawn pawn)
        {
            return pawn?.GetComp<CompAnimated>();
        }
    }
}