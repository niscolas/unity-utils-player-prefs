using UnityEngine;

namespace Plugins.ScriptablePlayerPrefs {
	[CreateAssetMenu(menuName = BaseCreateAssetMenuPath + "Entry (Int)", order = CreateAssetMenuOrder)]
	class ScriptablePlayerPrefsIntEntry : BaseScriptablePlayerPrefsEntry<int> {
		public override int Get() {
			return PlayerPrefs.GetInt(keyRef.Value);
		}

		public override int Get(int defaultValue) {
			return PlayerPrefs.GetInt(keyRef.Value, defaultValue);
		}

		public override void Save(int value) {
			PlayerPrefs.SetInt(keyRef.Value, value);
			PlayerPrefs.Save();
		}
	}
}