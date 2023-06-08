using UnrealBuildTool;

public class SummerGJ2023Target : TargetRules
{
	public SummerGJ2023Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SummerGJ2023");
	}
}
