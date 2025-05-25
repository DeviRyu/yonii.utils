using System;
using System.IO;

namespace Yonii.Utils
{
    public static class FileInfoExtensions
    {
        public static void Rename(this FileInfo file, string newFileName)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));
            if (string.IsNullOrEmpty(newFileName))
                throw new ArgumentException("New filename must be provided.", nameof(newFileName));
            if (file.Directory == null)
                throw new InvalidOperationException("File must have a parent directory.");

            var newPath = Path.Combine(file.Directory.FullName, newFileName);

            // Move the file to new name
            file.MoveTo(newPath);

        }
    }
}