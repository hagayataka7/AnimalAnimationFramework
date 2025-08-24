using Verse;
using RimWorld;
using System.Linq;
using LudeonTK;  // 🔹 DebugActionAttribute が Verse ではなくこちら

namespace AnimalAnimationFramework
{
    public static class DebugTools_Animation
    {
        [DebugAction("AAF", "選択PawnでIdleアニメ再生", actionType = DebugActionType.ToolMap)]
        public static void PlayIdle()
        {
            var pawn = Find.Selector.SingleSelectedThing as Pawn;
            if (pawn == null) return;

            var comp = pawn.GetComp<CompAnimated>();
            if (comp != null)
            {
                var def = DefDatabase<AnimationDef>.AllDefs.FirstOrDefault(d => d.defName.Contains("Idle"));
                if (def != null) comp.StartAnimation(def);
            }
        }

        [DebugAction("AAF", "選択Pawnのアニメ停止", actionType = DebugActionType.ToolMap)]
        public static void StopAnimation()
        {
            var pawn = Find.Selector.SingleSelectedThing as Pawn;
            pawn?.GetComp<CompAnimated>()?.StopAnimation();
        }
    }
}
