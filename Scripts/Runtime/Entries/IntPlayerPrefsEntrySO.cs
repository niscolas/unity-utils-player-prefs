using UnityEngine;

namespace niscolas.UnityUtils.PlayerPrefs
{
    [CreateAssetMenu(
        menuName = Constants.CreateAssetMenuPrefix + "Entry (Int)",
        order = Constants.CreateAssetMenuOrder)]
    public class IntPlayerPrefsEntrySO : BasePlayerPrefsEntrySO<int>
    {
        public override int Get()
        {
            return UnityEngine.PlayerPrefs.GetInt(_key.Value);
        }

        public override int Get(int defaultValue)
        {
            return UnityEngine.PlayerPrefs.GetInt(_key.Value, defaultValue);
        }

        public override void Save(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(_key.Value, value);
            UnityEngine.PlayerPrefs.Save();
        }
    }
}