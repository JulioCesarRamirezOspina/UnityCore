using System;
using System.Collections.Generic;
using UnityEngine;
using Yosoft.Flujo.Runtime.Common.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.MicroAnimations
{
	[Serializable]
	public class EditorMicroAnimationInfo
	{
		public string AnimationName;
		public List<Texture2D> Textures;
		
		public void ValidateName() =>
			AnimationName = AnimationName.RemoveWhitespaces().RemoveAllSpecialCharacters();
	}
}