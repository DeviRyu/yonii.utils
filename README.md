# yonii.utils

**Yonii.Utils** is a collection of reusable C# utility classes, algorithms, and helpers designed to simplify and streamline .NET development. The library targets both .NET 9.0 and .NET Standard 2.1, making it suitable for a wide range of projects including modern and legacy environments.

## Features

- **Thread-safe Singleton Implementation**: Provides a robust, generic way to implement singletons for classes, including those with private constructors.
- **Useful Helpers & Extensions**: Designed to grow with additional algorithms and extension methods to support everyday programming tasks.

## Installation

You can add Yonii.Utils to your project using one of the following methods:

### Using the Package Manager Console
You can search for `Yonii.Utils` in the NuGet package manager within Visual Studio or your favorite IDE.


## Usage Example

A common use case is implementing singletons safely:

    public class Logger
    {
        // Private constructor prevents direct instantiation
        private Logger() { }

        // Access the singleton instance
        public static Logger Instance = Singleton&lt;Logger&gt;.GetInstance(() => new Logger());

        public void Log(string message) => Console.WriteLine(message);
    }

## Target Frameworks

- **.NET 9.0**
- **.NET Standard 2.1**

## Contributing

Contributions of new utilities, helpers, or improvements are welcome! Please submit pull requests or suggest features by opening an issue.

## License

This project is licensed under the MIT License.

---

**Yonii.Utils** aims to be your handy toolbox of tried-and-true C# utilities.

