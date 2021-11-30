namespace TutorialPlugin;
using Exiled.API.Enums;
using Exiled.API.Features;
using System;

public class Tutorial : Plugin<Config>
{

    private static readonly Tutorial Wow = new Tutorial();

    public static Tutorial Instance => Wow;

    private Tutorial()
    {
    }

    public override PluginPriority Priority { get; } = PluginPriority.Last;
    public override void OnEnabled()
    {
        RegisterEvents();

        Log.Warn($"I correctly read the string config, its value is: {Config.String}");
        Log.Warn($"I correctly read the int config, its value is: {Config.Int}");
        Log.Warn($"I correctly read the float config, its value is: {Config.Float}");

        base.OnEnabled();
    }

}