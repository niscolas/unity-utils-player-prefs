using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.ScriptablePlayerPrefsEntry {
	public abstract class BaseScriptablePlayerPrefsEntry<T> : ScriptableObject {
		protected const int CreateAssetMenuOrder = -30;
		protected const string BaseCreateAssetMenuPath = "Scriptable Player Prefs/";

		[SerializeField]
		protected StringReference keyRef;

		[SerializeField]
		private T valueToSave;

		public abstract T Get();

		public abstract T Get(T defaultValue);

		public abstract void Save(T value);

		public void PrintGet() {
			Debug.Log(Get());
		}

		public void SaveInspectorValue() {
			Save(valueToSave);
		}
	}
}