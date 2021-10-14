using UnityEngine;

namespace niscolas.UnityUtils.PlayerPrefs
{
    [CreateAssetMenu(
        menuName = Constants.CreateAssetMenuPrefix + "Entry (string)",
        order = Constants.CreateAssetMenuOrder)]
    public class StringPlayerPrefsEntrySO : BasePlayerPrefsEntrySO<string>
    {
        public override string Get()
        {
            return UnityEngine.PlayerPrefs.GetString(_key.Value);
        }

        public override string Get(string defaultValue)
        {
            return UnityEngine.PlayerPrefs.GetString(_key.Value, defaultValue);
        }

        public override void Save(string value)
        {
            UnityEngine.PlayerPrefs.SetString(_key.Value, value);
            UnityEngine.PlayerPrefs.Save();
        }
    }
}