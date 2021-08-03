using UnityEngine;

namespace Plugins.ScriptablePlayerPrefs {
	[CreateAssetMenu(menuName = BaseCreateAssetMenuPath + "Entry (string)", order = CreateAssetMenuOrder)]
	public class ScriptablePlayerPrefsStringEntry : BasePlayerPrefsEntrySO<string> {
		public override string Get() {
			return PlayerPrefs.GetString(keyRef.Value);
		}

		public override string Get(string defaultValue) {
			return PlayerPrefs.GetString(keyRef.Value, defaultValue);
		}

		public override void Save(string value) {
			PlayerPrefs.SetString(keyRef.Value, value);
			PlayerPrefs.Save();
		}
	}
}