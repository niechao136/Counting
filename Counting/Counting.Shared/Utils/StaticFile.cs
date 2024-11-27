namespace Counting.Shared.Utils;

public static class StaticFile
{
    public static string HandlePath(string path)
    {
        return $"/_content/Counting.Shared/{path}";
    }
}
