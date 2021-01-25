using NaughtyAttributes;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.ScriptablePlayerPrefsEntry {
	public abstract class BaseScriptablePlayerPrefsEntry<T> : ScriptableObject {
		protected const int CreateAssetMenuOrder = -30;
		protected const string BaseCreateAssetMenuPath = "Scriptable Player Prefs/";

		[SerializeField]
		protected StringReference keyRef;

		[ShowNativeProperty]
		public T SavedValue => Get();

		public abstract T Get();

		public abstract T Get(T defaultValue);

		public abstract void Save(T value);
	}
}