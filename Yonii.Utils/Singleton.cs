namespace Yonii.Utils;

/// <summary>
/// Thread-safe without locks singleton pattern which can be used to create different types of singleton(s).
/// More info can be read at: https://csharpindepth.com/articles/singleton#lock
/// </summary>
/// <typeparam name="T">The type of singleton you would like to create</typeparam>
public class Singleton<T> where T : class, new()
{
    public static T Instance { get; } = new();

    static Singleton()
    {
    }

    protected Singleton()
    {
    }
}