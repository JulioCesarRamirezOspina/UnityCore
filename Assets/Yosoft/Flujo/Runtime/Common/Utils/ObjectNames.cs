using System.Text.RegularExpressions;
using Yosoft.Flujo.Runtime.Common.Extensions;

namespace Yosoft.Flujo.Runtime.Common.Utils
{
    /// <summary> Helper class that contains methods that make names human readable </summary>
    public static class ObjectNames
    {
        /// <summary> Make a displayable name for a variable </summary>
        /// <param name="name"> Object name </param>
        public static string NicifyVariableName(string name)
        {
            if (name[0] == 'k') name = name.Right(name.Length - 1);
            name = name.Replace("m_", "").Replace("_", " ");
            name = Regex.Replace(name, "[A-Z]", " $0");
            name = name.TrimStart().TrimEnd();
            return name;
        }
    }
}
