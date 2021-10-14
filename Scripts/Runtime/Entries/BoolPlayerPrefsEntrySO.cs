using UnityEngine;

namespace niscolas.UnityUtils.PlayerPrefs
{
    [CreateAssetMenu(
        menuName = Constants.CreateAssetMenuPrefix + "Entry (Bool)",
        order = Constants.CreateAssetMenuOrder)]
    public class BoolPlayerPrefsEntrySO : BasePlayerPrefsEntrySO<bool>
    {
        public override bool Get()
        {
            return GetIntAsBool(UnityEngine.PlayerPrefs.GetInt(_key.Value));
        }

        public override bool Get(bool defaultValue)
        {
            int result = UnityEngine.PlayerPrefs.GetInt(_key.Value, GetBoolAsInt(defaultValue));
            return GetIntAsBool(result);
        }

        public override void Save(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(_key.Value, GetBoolAsInt(value));
            UnityEngine.PlayerPrefs.Save();
        }

        private static bool GetIntAsBool(int value)
        {
            return value == 1;
        }

        private static int GetBoolAsInt(bool value)
        {
            return value ? 1 : 0;
        }
    }
}