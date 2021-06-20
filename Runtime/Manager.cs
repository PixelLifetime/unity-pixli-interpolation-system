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

namespace PixLi
{
	public class Manager : MonoBehaviourSingleton<Manager>
	{
		public enum UpdateType { Update, LaterUpdate, FixedUpdate, ManualUpdate }

		private List<Tween> _updateTweens = new List<Tween>(32);
		private List<Tween> _lateUpdateTweens = new List<Tween>(32);
		private List<Tween> _fixedUpdateTweens = new List<Tween>(32);
		private List<Tween> _manualUpdateTweens = new List<Tween>(32);

		public void Add(Tween tween, UpdateType updateType)
		{
			switch (updateType)
			{
				case UpdateType.Update:

					this._updateTweens.Add(tween);

					break;
				case UpdateType.LaterUpdate:

					this._lateUpdateTweens.Add(tween);

					break;
				case UpdateType.FixedUpdate:

					this._fixedUpdateTweens.Add(tween);

					break;
				case UpdateType.ManualUpdate:

					this._manualUpdateTweens.Add(tween);

					break;
			}
		}

		private void Update()
		{
			for (int a = 0; a < this._updateTweens.Count; a++)
			{
				this._updateTweens[a].Update(Time.deltaTime);
			}
		}

		private void LateUpdate()
		{
			for (int a = 0; a < this._lateUpdateTweens.Count; a++)
			{
				this._lateUpdateTweens[a].Update(Time.deltaTime);
			}
		}

		private void FixedUpdate()
		{
			for (int a = 0; a < this._fixedUpdateTweens.Count; a++)
			{
				this._fixedUpdateTweens[a].Update(Time.fixedDeltaTime);
			}
		}

#if UNITY_EDITOR
		//protected virtual void OnDrawGizmos()
		//{
		//}

		[CustomEditor(typeof(Manager)), CanEditMultipleObjects]
		public class ManagerEditor : MultiSupportEditor
		{
			private Manager _tManager;

			public override void OnEnable()
			{
				base.OnEnable();

				this._tManager = this.target as Manager;
			}

			public override void MainDrawGUI()
			{
				this.DrawDefaultInspector();
			}
		}
#endif
	}
}