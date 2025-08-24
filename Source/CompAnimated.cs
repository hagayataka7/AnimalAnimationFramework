using Verse;

namespace AnimalAnimationFramework
{
    public class CompAnimated : ThingComp
    {
        public AnimationPlayer player = new AnimationPlayer();

        public override void CompTick()
        {
            base.CompTick();
            player.Tick();
        }

        public void StartAnimation(AnimationDef def)
        {
            player.Start(def);
        }

        public void StopAnimation()
        {
            player.Stop();
        }

        public string CurrentFrameTex => player.CurrentFrameTexPath;

        // 🔹 追加: 現在のアニメーション名
        public string CurrentAnimationName => player.CurrentAnimation?.defName ?? "None";
    }
}
