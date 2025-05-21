![Build][build-shield]
[![Contributors][contributors-shield]][contributors-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![License][license-shield]][license-url]
![Releases][releases-shield]

<br />
<div align="center">
  <a href="https://github.com/DeviRyu/yonii.utils">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h1 align="center">yonii龍神's Utilities Library</h1>

  <p align="center">
     Is a collection of reusable C# utility classes, algorithms, and helpers designed to simplify and streamline .NET development. The library targets both .NET 9.0 and .NET Standard 2.1, making it suitable for a wide range of projects including modern and legacy environments.
    <br />
    <a href="https://github.com/DeviRyu/yonii.utils"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/DeviRyu/yonii.utils">View Demo</a>
    &middot;
    <a href="https://github.com/DeviRyu/yonii.utils/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    &middot;
    <a href="https://github.com/DeviRyu/yonii.utils/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>

## Features

- **Thread-safe Singleton Implementation**: Provides a robust, generic way to implement singletons for classes, including those with private constructors.
- **ObjectKey Struct**: The `ObjectKey` struct provides an efficient, type-safe value object for identifying entities by either a numeric ID or a GUID (globally unique identifier). It is especially useful when you want to uniformly manage references to both static (predetermined) and dynamically created objects without ambiguity.
This type ensures uniqueness, value-based equality, and is suitable for use as a key in collections such as dictionaries or hash sets.

- **Useful Helpers & Extensions**: Designed to grow with additional algorithms and extension methods to support everyday programming tasks.

_For more features, please refer to the [Documentation](https://example.com)_

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
        public static Logger Instance = Singleton<Logger>.GetInstance(() => new Logger());

        public void Log(string message) => Console.WriteLine(message);
    }

_For more examples, please refer to the [Documentation](https://example.com)_

## Target Frameworks

- **.NET 9.0**
- **.NET Standard 2.1**

## Contributing

Contributions of new utilities, helpers, or improvements are welcome! Please submit pull requests or suggest features by opening an issue.

## License

This project is licensed under the MIT License.

---

**Yonii.Utils** aims to be your handy toolbox of tried-and-true C# utilities.

<!-- MARKDOWN LINKS & IMAGES -->
[build-shield]: https://img.shields.io/github/actions/workflow/status/DeviRyu/yonii.utils/publish-to-nuget.yml?style=for-the-badge
[contributors-shield]: https://img.shields.io/github/contributors/DeviRyu/yonii.utils.svg?style=for-the-badge
[contributors-url]: https://github.com/DeviRyu/yonii.utils/graphs/contributors
[stars-shield]: https://img.shields.io/github/stars/DeviRyu/yonii.utils.svg?style=for-the-badge
[stars-url]: https://github.com/DeviRyu/yonii.utils/stargazers
[issues-shield]: https://img.shields.io/github/issues/DeviRyu/yonii.utils.svg?style=for-the-badge
[issues-url]: https://github.com/DeviRyu/yonii.utils/issues
[license-shield]: https://img.shields.io/github/license/DeviRyu/yonii.utils.svg?style=for-the-badge
[license-url]: https://github.com/DeviRyu/yonii.utils/blob/master/LICENSE.txt
[releases-shield]: https://img.shields.io/github/v/release/DevIryu/yonii.utils?display_name=tag&style=for-the-badge
