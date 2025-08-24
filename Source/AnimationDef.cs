using Verse;
using System.Collections.Generic;

namespace AnimalAnimationFramework
{
    /// <summary>
    /// アニメーション本体を定義する Def。
    /// フレームのテクスチャリストを保持する。
    /// </summary>
    public class AnimationDef : Def
    {
        public List<string> frames;   // 画像ファイルのパス一覧
        public int ticksPerFrame = 10;
        public bool loop = true;
    }
}
