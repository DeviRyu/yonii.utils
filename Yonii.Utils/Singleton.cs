namespace Yonii.Utils;

/// <summary>
/// A thread-safe, generic singleton helper that provides easy access to singleton instances.
/// Supports classes with private constructors.
/// </summary>
/// <typeparam name="T">The type to create as a singleton.</typeparam>
/// <remarks>
/// This implementation uses a thread-safe lazy initialization pattern.
/// </remarks>
/// <example>
/// Define a singleton class:
/// <code>
/// public class Logger
/// {
///     // Private constructor prevents direct instantiation
///     private Logger() { }
///     
///     // Access the singleton instance
///     public static Logger Instance = Singleton&lt;Logger&gt;.GetInstance(() => new Logger());
///     
///     public void Log(string message) => Console.WriteLine(message);
/// }
/// 
/// // Usage
/// Logger.Instance.Log("Hello World");
/// </code>
/// </example>
public sealed class Singleton<T> where T : class
{
    // Lazy<T> ensure thread-safe initialisation
    private static Lazy<T>? _instance;
    
    // Lock object for thread safety during initialization of Lazy<T>
    // ReSharper disable StaticMemberInGenericType once
    // ReSharper disable once InconsistentNaming
    private static readonly object _lock = new();
    
    /// <summary>
    /// Gets the singleton instance using the provided factory method.
    /// </summary>
    /// <param name="factory">Factory method to create the instance if it doesn't exist.</param>
    /// <returns>The singleton instance.</returns>
    public static T GetInstance(Func<T> factory)
    {
        if (_instance != null)
        {
            return _instance.Value;
        }

        lock (_lock)
        {
            _instance ??= new Lazy<T>(factory, LazyThreadSafetyMode.ExecutionAndPublication);
        }

        return _instance.Value;
    }
}