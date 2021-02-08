using UnityEngine;

namespace Plugins.ScriptablePlayerPrefs {
	[CreateAssetMenu(menuName = BaseCreateAssetMenuPath + "Entry (Float)", order = CreateAssetMenuOrder)]
	public class ScriptablePlayerPrefsFloatEntry : BaseScriptablePlayerPrefsEntry<float> {
		public override float Get() {
			return PlayerPrefs.GetFloat(keyRef.Value);
		}

		public override float Get(float defaultValue) {
			return PlayerPrefs.GetFloat(keyRef.Value, defaultValue);
		}

		public override void Save(float value) {
			PlayerPrefs.SetFloat(keyRef.Value, value);
			PlayerPrefs.Save();
		}
	}
}