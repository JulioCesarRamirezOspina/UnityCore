using System;
using System.IO;
using Yosoft.Flujo.Editor.UIManager;
using Yosoft.Flujo.Runtime.Common;
using Yosoft.Flujo.Runtime.Common.Extensions;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.Common.Utils
{
    public static class FileGenerator
    {
        public static class Markers
        {
            internal const string k_Class = "%CLASS%";
            internal const string k_Content = "%CONTENT%";
            internal const string k_Namespace = "%NAMESPACE%";
            internal const string k_Using = "%USING%";
        }

        public static string templatesFolderPath => EditorUIManagerPath.automationTemplatesFolderPath;

        public static string GetTemplateFilePath(string fileName) =>
            $"{templatesFolderPath}/{fileName}";

        public static string GetTemplate(string fileName)
        {
            string templatePath = GetTemplateFilePath(fileName);
            return GetFile(templatePath);
        }

        public static string GetFile(string path)
        {
            if (File.Exists(path)) return File.ReadAllText(path);
            Debugger.LogError($"File Not Found: {path}");
            return string.Empty;
        }

        public static bool WriteFile(string filePath, string data, bool silent = false)
        {
            if (filePath.IsNullOrEmpty())
            {
                Debugger.LogError("FilePath cannot be empty...");
                return false;
            }

            if (data.IsNullOrEmpty())
            {
                Debugger.LogError("Data cannot be empty...");
                return false;
            }

            if (!silent) Debugger.Log($"Writing file {filePath}");
            File.WriteAllText(filePath, data);
            return true;
        }
        
        /// <summary> Cleans any path returning Assets/... </summary>
        /// <param name="rawPath"> Raw path </param>
        public static string CleanPath(string rawPath)
        {
            string path = rawPath.Replace('\\', '/');
            int index = path.IndexOf("Assets/", StringComparison.Ordinal);
            path = path.Substring(index);
            return path;
        }
    }
}
