
# Animal Animation Framework — Source

This is a minimal, buildable skeleton for RimWorld 1.5 / 1.6.
It matches the workshop-ready mod structure you exported separately.

## Build Steps (Windows, Visual Studio / Rider)
1) Copy required game assemblies into `References/` from your RimWorld install:
   - RimWorldWin64_Data/Managed/Assembly-CSharp.dll
   - RimWorldWin64_Data/Managed/UnityEngine.dll
   - RimWorldWin64_Data/Managed/UnityEngine.CoreModule.dll
   - RimWorldWin64_Data/Managed/UnityEngine.TextRenderingModule.dll
   - RimWorldWin64_Data/Managed/UnityEngine.IMGUIModule.dll
   - …(add more UnityEngine.* if your compiler complains)

2) Open `AnimalAnimationFramework.sln` and build in **Release**.
   The output DLL will be placed in `../AnimalAnimationFramework/Assemblies/AnimalAnimationFramework.dll`
   (post-build event).

3) Copy your textures/XML into the mod folder if you add more samples.

Notes:
- This is a framework skeleton with stubs for: Mod entry, Settings, EndConditionRegistry, and AnimationManager.
- Fill in TODO sections to complete the features specific to your project.
