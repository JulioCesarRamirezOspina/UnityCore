using Yosoft.Flujo.Runtime.Common;

namespace Yosoft.Flujo.Editor.UIManager
{
	internal class EditorUIManagerPath : BasePathFinder<EditorUIManagerPath>
	{
		// ReSharper disable once MemberCanBePrivate.Global
		internal static string automationFolderPath => $"{path}/Automation";
		internal static string automationTemplatesFolderPath => $"{automationFolderPath}/Templates";
	}
}