using System.Collections.Generic;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// アニメーション終了条件を管理するレジストリ。
    /// 将来的に条件追加する際に拡張予定。
    /// </summary>
    public static class EndConditionRegistry
    {
        public static List<string> Conditions = new List<string> { "OnJobEnd", "OnSleepEnd" };
    }
}
