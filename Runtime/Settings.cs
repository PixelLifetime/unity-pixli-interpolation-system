using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;
using MinAttribute = PixLi.MinAttribute;

namespace PixLi
{
	public class Settings : ScriptableObjectSingleton<Settings>
	{
		[Min(0f)]
		[SerializeField] private float _defaultTimeScale = 1f;
		public float DefaultTimeScale => this._defaultTimeScale;

		protected override string GetInstanceDirectoryPath() => PathUtility.GetScriptFileDirectoryPath();

		//protected virtual void OnDrawGizmos()
		//{
		//}

#if UNITY_EDITOR
		[CustomEditor(typeof(Settings)), CanEditMultipleObjects]
		public class SettingsEditor : MultiSupportEditor
		{
			private Settings _tSettings;

			public override void OnEnable()
			{
				base.OnEnable();

				this._tSettings = this.target as Settings;
			}

			public override void MainDrawGUI()
			{
				this.DrawDefaultInspector();
			}
		}
#endif
	}
}