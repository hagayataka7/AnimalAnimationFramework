using Verse;
using Verse.AI;
using System.Collections.Generic;

namespace AnimalAnimationFramework
{
    public class JobDriver_Animation : JobDriver
    {
        public override bool TryMakePreToilReservations(bool errorOnFailed) => true;

        protected override IEnumerable<Toil> MakeNewToils()
        {
            Toil playAnim = new Toil();
            playAnim.initAction = () =>
            {
                var pawn = GetActor();
                var comp = pawn.GetComp<CompAnimated>();
                if (comp != null)
                {
                    var anim = DefDatabase<AnimationDef>.GetNamedSilentFail(job.def.defName);
                    if (anim != null)
                        comp.StartAnimation(anim);
                }
            };
            playAnim.tickAction = () => { };
            yield return playAnim;
        }
    }
}
