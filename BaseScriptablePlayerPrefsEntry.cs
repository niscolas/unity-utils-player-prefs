using UnityAtoms.BaseAtoms;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif

namespace Plugins.ScriptablePlayerPrefs {
	public abstract class BaseScriptablePlayerPrefsEntry<T> : ScriptableObject {
		protected const int CreateAssetMenuOrder = -30;
		protected const string BaseCreateAssetMenuPath = "Scriptable Player Prefs/";

		[SerializeField]
		protected StringReference keyRef;

#if ODIN_INSPECTOR
		[SerializeField]
		private T valueToSave;
		
		[ShowInInspector]
		public T SavedValue => Get();

		[Button]
		private void SaveValue() {
			Save(valueToSave);
		} 
#endif

		public abstract T Get();

		public abstract T Get(T defaultValue);

		public abstract void Save(T value);
	}
}