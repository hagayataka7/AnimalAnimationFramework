using Verse;
using UnityEngine;
using System.Collections.Generic;

namespace AnimalAnimationFramework
{
    public class AnimationPlayer
    {
        private int currentFrame;
        private int frameTick;
        private AnimationDef currentAnimation;
        private bool isPlaying;

        public void Start(AnimationDef def)
        {
            currentAnimation = def;
            currentFrame = 0;
            frameTick = 0;
            isPlaying = true;
            Log.Message($"[AAF] アニメーション開始: {def.defName}");
        }

        public void Stop()
        {
            isPlaying = false;
            Log.Message("[AAF] アニメーション停止");
        }

        public void Tick()
        {
            if (!isPlaying || currentAnimation == null) return;

            frameTick++;
            if (frameTick >= currentAnimation.ticksPerFrame)
            {
                frameTick = 0;
                currentFrame++;
                if (currentFrame >= currentAnimation.frames.Count)
                {
                    if (currentAnimation.loop)
                        currentFrame = 0;
                    else
                        Stop();
                }
            }
        }

        public string CurrentFrameTexPath =>
            currentAnimation != null && currentFrame < currentAnimation.frames.Count
                ? currentAnimation.frames[currentFrame]
                : null;

        // 🔹 追加: 外部参照用
        public AnimationDef CurrentAnimation => currentAnimation;
    }
}
