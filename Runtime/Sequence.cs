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
	public class Sequence
	{
		private Stack<Tween> _tweens;

		private int _activeTweenIndex;

		public void Add(Tween tween)
		{
			this._tweens.Push(tween);
		}

		public void Reset()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Restart()
		{
			this.Reset();
			this.Play();
		}

#if UNITY_EDITOR
		//[CustomEditor(typeof(Sequence)), CanEditMultipleObjects]
		//public class SequenceEditor : MultiSupportEditor
		//{
		//	private Sequence _tSequence;

		//	public override void OnEnable()
		//	{
		//		base.OnEnable();

		//		this._tSequence = this.target as Sequence;
		//	}

		//	public override void MainDrawGUI()
		//	{
		//		this.DrawDefaultInspector();
		//	}
		//}
#endif
	}
}