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
	public abstract class Tween
	{
		protected Settings settings;

		public abstract void Update(float modifier);

		public abstract void Reset();
		public abstract void Play();
		public abstract void Pause();

		public void Restart()
		{
			this.Reset();
			this.Play();
		}

#if UNITY_EDITOR
		//[CustomEditor(typeof(Tween)), CanEditMultipleObjects]
		//public class TweenEditor : MultiSupportEditor
		//{
		//	private Tween _tTween;

		//	public override void OnEnable()
		//	{
		//		base.OnEnable();

		//		this._tTween = this.target as Tween;
		//	}

		//	public override void MainDrawGUI()
		//	{
		//		this.DrawDefaultInspector();
		//	}
		//}
#endif
	}

	public class Tween<TValue> : Tween
	{
		protected TValue startValue;
		public TValue StartValue => this.startValue;

		protected TValue endValue;
		public TValue EndValue => this.endValue;

		public override void Update(float modifier)
		{
			throw new NotImplementedException();
		}

		public override void Reset()
		{
			throw new NotImplementedException();
		}

		public override void Play()
		{
			throw new NotImplementedException();
		}

		public override void Pause()
		{
			throw new NotImplementedException();
		}
	}
}