namespace CodeGeneration.Tests;

public static class VerifyHelper
{
    /// <summary>
    /// Helper to run verify tests with sane defaults.
    /// </summary>
    public static Task Verify(string output, Func<SettingsTask, SettingsTask>? action = null)
    {
        var settings = Verifier
            .Verify(output)
            .ScrubLinesContaining(
                StringComparison.OrdinalIgnoreCase,
                "Generated using the NSwag toolchain"
            )
            .UseDirectory("Snapshots");

        if (action != null)
            settings = action.Invoke(settings);
        return settings.ToTask();
    }
}
